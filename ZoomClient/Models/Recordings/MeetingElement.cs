using System;

namespace AndcultureCode.ZoomClient.Models.Recordings
{
    /// <summary>
    /// The recording meeting object.
    /// </summary>
    public partial class MeetingElement
    {
        /// <summary>
        /// Unique Identifier of the user account.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Meeting duration.
        /// </summary>
        public long? Duration { get; set; }

        /// <summary>
        /// ID of the user set as host of meeting.
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// Meeting ID - also known as the meeting number.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Number of recording files returned in the response of this API call.
        /// </summary>
        public string RecordingCount { get; set; }

        /// <summary>
        /// List of recording file.
        /// </summary>
        public RecordingFileElement[] RecordingFiles { get; set; }

        /// <summary>
        /// The time at which the meeting started.
        /// </summary>
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Meeting topic.
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Total size of the recording.
        /// </summary>
        public string TotalSize { get; set; }

        /// <summary>
        /// Unique Meeting Identifier. Each instance of the meeting will have its own UUID.
        /// </summary>
        public string Uuid { get; set; }
    }
}