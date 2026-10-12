using Verizon.Core.Models;

namespace Verizon.Requests.ConfigurationFiles;

/// <summary>
/// The inputs of the UploadConfigFile operation.
/// </summary>
public sealed record UploadConfigFileRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// The file to upload.
    /// </summary>
    public BinaryContent? Fileupload { get; init; }

    /// <summary>
    /// Version of the file.
    /// </summary>
    public string? FileVersion { get; init; }

    /// <summary>
    /// The software-applicable device make.
    /// </summary>
    public string? Make { get; init; }

    /// <summary>
    /// The software-applicable device model.
    /// </summary>
    public string? Model { get; init; }

    /// <summary>
    /// Local target path on the device.
    /// </summary>
    public string? LocalTargetPath { get; init; }
}
