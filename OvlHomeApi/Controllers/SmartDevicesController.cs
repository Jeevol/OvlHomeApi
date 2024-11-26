using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OvlHomeApi.Enums;
using OvlHomeApi.Models;

namespace OvlHomeApi.Controllers;

public static class TestLightProps
{
    public static bool IsEnabled { get; set; } = true;
    public static float Brightness { get; set; } = 50;
    public static int TemperatureK { get; set; } = 4500;
    public static float BatteryLevel { get; set; } = 70;
}

[ApiController]
[Route("/api/yandex/v1.0/user/devices")]
[Authorize]
public class SmartDevicesController(ILogger<SmartDevicesController> logger) : ControllerBase
{
    [HttpGet]
    public IActionResult GetDevices([FromHeader(Name = "X-Request-Id")] string requestId)
    {
        logger.Log(LogLevel.Information, "{time} | GetDevices [{user}] - Id: {id}", DateTime.Now, User.Identity?.Name ?? "anonymous", requestId);
        return base.Ok(new Root
        {
            RequestId = requestId,
            Payload = new Payload
            {
                UserId = User.Identity?.Name,
                Devices =
                [
                    new Device
                    {
                        Id = "2",
                        Name = "Крутая лампочка",
                        Description = "Описание крутой лампочки",
                        Room = "Зал",
                        Type = DeviceType.Light,
                        CustomData = new Dictionary<string, object>
                        {
                            ["Aboba"] = true,
                            ["SmartProp"] = "Woah!",
                            ["Cat"] = new Dictionary<string, object> { ["Id"] = 1, ["Meow"] = true}
                        },
                        Capabilities =
                        [
                            new Capability
                            {
                                Type = CapabilityType.OnOff,
                                Retrievable = true
                            },
                            new Capability
                            {
                                Type = CapabilityType.Range,
                                Retrievable = true,
                                Parameters = new CapabilityParameters
                                {
                                    Instance = CapabilityInstance.Brightness,
                                    RandomAccess = true,
                                    Range = new CapabilityRange
                                    {
                                        Max = 100,
                                        Min = 1,
                                        Precision = 1
                                    },
                                    Unit = Unit.Percent
                                }
                            },
                            new Capability
                            {
                                Type = CapabilityType.ColorSetting,
                                Retrievable = true,
                                Parameters = new CapabilityParameters
                                {
                                    TemperatureK = new TemperatureRange
                                    {
                                        Max = 6500,
                                        Min = 2700
                                    }
                                }
                            }
                        ],
                        Properties =
                        [
                            new Property
                            {
                                Type = PropertyType.Float,
                                Retrievable = true,
                                Parameters = new PropertyParameters
                                {
                                    Instance = PropertyInstance.BatteryLevel,
                                    Unit = Unit.Percent
                                }
                            }
                        ],
                        DeviceInfo = new DeviceInfo
                        {
                            Manufacturer = "Ovl Test",
                            Model = "Самая крутая модель",
                            HwVersion = "hw1.0",
                            SwVersion = "sw1.0"
                        }
                    }
                ]
            }
        });
    }

    [HttpPost("query")]
    public IActionResult GetDevicesState([FromHeader(Name = "X-Request-Id")] string requestId, [FromBody] Payload body)
    {
        logger.Log(LogLevel.Information, "{time} | GetDevicesState [{user}] - Id: {id}, Body = {body}", DateTime.Now, User.Identity?.Name ?? "anonymous", requestId, body.Devices.First().Id);
        return Ok(new Root
        {
            RequestId = requestId,
            Payload = new Payload
            {
                Devices =
                [
                    new Device
                    {
                        Id = "2",
                        Capabilities =
                        [
                            new Capability
                            {
                                Type = CapabilityType.OnOff,
                                State = new CapabilityState
                                {
                                    Instance = CapabilityInstance.On,
                                    OnValue = TestLightProps.IsEnabled
                                }
                            },
                            new Capability
                            {
                                Type = CapabilityType.Range,
                                State = new CapabilityState
                                {
                                    Instance = CapabilityInstance.Brightness,
                                    RangeValue = TestLightProps.Brightness
                                }
                            },
                            new Capability
                            {
                                Type = CapabilityType.ColorSetting,
                                State = new CapabilityState
                                {
                                    Instance = CapabilityInstance.TemperatureK,
                                    ColorValue = TestLightProps.TemperatureK
                                }
                            }
                        ],
                        Properties =
                        [
                            new Property
                            {
                                Type = PropertyType.Float,
                                State = new PropertyState
                                {
                                    Instance = PropertyInstance.BatteryLevel,
                                    FloatValue = TestLightProps.BatteryLevel
                                }
                            }
                        ]
                    }
                ]
            }
        });
    }

    [HttpPost("action")]
    public IActionResult SetDevicesState([FromHeader(Name = "X-Request-Id")] string requestId, [FromBody] Root body)
    {
        logger.Log(LogLevel.Information, "{time} | SetDevicesState [{user}] - Id: {id}, Body = {body}", DateTime.Now, User.Identity?.Name ?? "anonymous", requestId, body.Payload!.Devices.First().Id);

        if (body.Payload!.Devices.First().Capabilities!.Any(c => c.Type == CapabilityType.OnOff))
            TestLightProps.IsEnabled = (bool)body.Payload!.Devices.First().Capabilities!.First(c => c.Type == CapabilityType.OnOff).State!.OnValue!;
        if (body.Payload!.Devices.First().Capabilities!.Any(c => c.Type == CapabilityType.Range))
            TestLightProps.Brightness = (float)body.Payload!.Devices.First().Capabilities!.First(c => c.Type == CapabilityType.Range).State!.RangeValue!;
        if (body.Payload!.Devices.First().Capabilities!.Any(c => c.Type == CapabilityType.ColorSetting))
            TestLightProps.TemperatureK = (int)body.Payload!.Devices.First().Capabilities!.First(c => c.Type == CapabilityType.ColorSetting).State!.ColorValue!;

        return Ok(new Root
        {
            RequestId = requestId,
            Payload = new Payload
            {
                Devices =
                [
                    new Device
                    {
                        Id = "2",
                        //Capabilities =
                        //[
                        //    new Capability
                        //    {
                        //        Type = CapabilityType.OnOff,
                        //        State = new CapabilityState
                        //        {
                        //            Instance = CapabilityInstance.On,
                        //            ActionResult = new Models.ActionResult
                        //            {
                        //                Status = Status.Done
                        //            }
                        //        }
                        //    },
                        //    new Capability
                        //    {
                        //        Type = CapabilityType.Range,
                        //        State = new CapabilityState
                        //        {
                        //            Instance = CapabilityInstance.Brightness,
                        //            ActionResult = new Models.ActionResult
                        //            {
                        //                Status= Status.Done
                        //            }
                        //        }
                        //    },
                        //    new Capability
                        //    {
                        //        Type = CapabilityType.ColorSetting,
                        //        State = new CapabilityState
                        //        {
                        //            Instance = CapabilityInstance.TemperatureK,
                        //            ActionResult = new Models.ActionResult
                        //            {
                        //                Status = Status.Done
                        //            }
                        //        }
                        //    }
                        //]
                        ActionResult = new Models.ActionResult
                        {
                            Status = Status.Done
                        }
                    }
                ]
            }
        });
    }
}
