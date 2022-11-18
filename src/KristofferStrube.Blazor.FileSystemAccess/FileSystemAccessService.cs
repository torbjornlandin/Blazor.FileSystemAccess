using Microsoft.JSInterop;

namespace KristofferStrube.Blazor.FileSystemAccess;

internal class FileSystemAccessService : 
    BaseFileSystemAccessService<
        FileSystemFileHandle,
        FileSystemDirectoryHandle,
        IJSObjectReference>,
    IFileSystemAccessService
{
    public FileSystemAccessService(IJSRuntime jSRuntime) : base(jSRuntime)
    {
    }

    protected override Task<FileSystemDirectoryHandle> CreateDirectoryHandleAsync(IJSRuntime jSRuntime, IJSObjectReference jSReference, FileSystemAccessOptions options)
        => Task.FromResult(new FileSystemDirectoryHandle(jSRuntime, jSReference, options));

    protected override Task<FileSystemFileHandle> CreateFileHandleAsync(IJSRuntime jSRuntime, IJSObjectReference jSReference, FileSystemAccessOptions options)
        => Task.FromResult(new FileSystemFileHandle(jSRuntime, jSReference, options));
}
