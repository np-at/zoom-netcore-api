using System;
using AndcultureCode.ZoomClient.Models.Recordings;

namespace AndcultureCode.ZoomClient.Interfaces
{
    public interface IZoomRecordingsClient
    {
        /// <summary>
        /// List recordings for a user. https://zoom.github.io/api/#cloud-recording
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="trashType"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="showTrash"></param>
        ListRecordings GetUserRecordings(string userId,
            DateTime from,
            DateTime to,
            string trashType = "meeting_recording",
            int pageSize = 30,
            int pageNumber = 1,
            bool showTrash = false);

        /// <summary>
        /// List Cloud Recordings available on an account. https://zoom.github.io/api/#cloud-recording
        /// To list recordings of a master account, the scope must be account:read:admin and the value of accountId should be me.
        /// </summary>
        /// <param name="accountId">Unique identifier of the account</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        ListRecordings GetAccountRecordings(string accountId, int pageSize = 30, int pageNumber = 1);
        
        /// <summary>
        /// Get Recording information about a meeting
        /// </summary>
        /// <param name="meetingId"></param>
        /// <returns></returns>
        RecordingFileList GetRecording(string meetingId);
        
        
    }
}