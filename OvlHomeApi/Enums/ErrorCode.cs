using System.Text.Json.Serialization;

namespace OvlHomeApi.Enums;

public enum ErrorCode
{
    [JsonStringEnumMemberName("DOOR_OPEN")]
    DoorOpen,
    [JsonStringEnumMemberName("LID_OPEN")]
    LidOpen,
    [JsonStringEnumMemberName("REMOTE_CONTROL_DISABLED")]
    RemoteControlDisabled,
    [JsonStringEnumMemberName("NOT_ENOUGH_WATER")]
    NotEnoughWater,
    [JsonStringEnumMemberName("LOW_CHARGE_LEVEL")]
    LowChargeLevel,
    [JsonStringEnumMemberName("CONTAINER_FULL")]
    ContainerFull,
    [JsonStringEnumMemberName("CONTAINER_EMPTY")]
    ContainerEmpty,
    [JsonStringEnumMemberName("DRIP_TRAY_FULL")]
    DripTrayFull,
    [JsonStringEnumMemberName("DEVICE_STUCK")]
    DeviceStick,
    [JsonStringEnumMemberName("DEVICE_OFF")]
    DeviceOff,
    [JsonStringEnumMemberName("FIRMWARE_OUT_OF_DATE")]
    FirmwareOutOfDate,
    [JsonStringEnumMemberName("NOT_ENOUGH_DETERGENT")]
    NotEnoughDetergent,
    [JsonStringEnumMemberName("HUMAN_INVOLVEMENT_NEEDED")]
    HumanInvolvementNeeded,
    [JsonStringEnumMemberName("DEVICE_UNREACHABLE")]
    DeviceUnreachable,
    [JsonStringEnumMemberName("DEVICE_BUSY")]
    DeviceBusy,
    [JsonStringEnumMemberName("INTERNAL_ERROR")]
    InternalError,
    [JsonStringEnumMemberName("INVALID_ACTION")]
    InvalidAction,
    [JsonStringEnumMemberName("INVALID_VALUE")]
    InvalidValue,
    [JsonStringEnumMemberName("NOT_SUPPORTED_IN_CURRENT_MODE")]
    NotSupportedInCurrentMode,
    [JsonStringEnumMemberName("ACCOUNT_LINKING_ERROR")]
    AccountLinkingError,
    [JsonStringEnumMemberName("DEVICE_NOT_FOUND")]
    DeviceNotFound
}
