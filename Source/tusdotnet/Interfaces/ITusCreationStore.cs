﻿using System.Threading;
using System.Threading.Tasks;

namespace tusdotnet.Interfaces
{
	public interface ITusCreationStore
	{
		/// <summary>
		/// Create a file upload reference that can later be used to upload data.
		/// </summary>
		/// <param name="uploadLength">The length of the upload in bytes</param>
		/// <param name="metadata">The Upload-Metadata request header or null if no header was provided</param>
		/// <param name="cancellationToken">Cancellation token to use when cancelling</param>
		/// <returns></returns>
		Task<string> CreateFileAsync(long uploadLength, string metadata, CancellationToken cancellationToken);

		/// <summary>
		/// Get the Upload-Metadata header as it was provided to <code>CreateFileAsync</code>.
		/// </summary>
		/// <param name="fileId">The id of the file to get the header for</param>
		/// <param name="cancellationToken">Cancellation token to use when cancelling</param>
		/// <returns>The Upload-Metadata header</returns>
		Task<string> GetUploadMetadataAsync(string fileId, CancellationToken cancellationToken);
	}
}