namespace AndcultureCode.ZoomClient.Models.Recordings
{
    /// <summary>
    /// Recording file object.
    /// </summary>
    public partial class RecordingFileElement
    {
        /// <summary>
        /// The time at which recording was deleted. Returned in the response only for trash query.
        /// </summary>
        public string DeletedTime { get; set; }

        /// <summary>
        /// The URL using which the recording file can be downloaded. **To access a private or
        /// password protected cloud recording, you must use a [Zoom JWT App
        /// Type](https://marketplace.zoom.us/docs/guides/getting-started/app-types/create-jwt-app).
        /// Use the generated JWT token as the value of the `access_token` query parameter and
        /// include this query parameter at the end of the URL as shown in the example.**
        /// <br>
        /// Example: `https://api.zoom.us/recording/download/{{ Download Path }}?access_token={{ JWT
        /// Token }}`
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// The recording file size.
        /// </summary>
        public double? FileSize { get; set; }

        /// <summary>
        /// The recording file type. The value of this field could be one of the following:<br>
        /// `MP4`: Video file of the recording.<br>`M4A` Audio-only file of the
        /// recording.<br>`TIMELINE`: Timestamp file of the recording.<br> `TRANSCRIPT`:
        /// Transcription file of the recording.<br> `CHAT`: A TXT file containing in-meeting chat
        /// messages that were sent during the meeting.<br>`CC`: File containing closed captions of
        /// the recording.<br><br>
        /// A recording file object with file type of either `CC` or `TIMELINE` **does not have** the
        /// following properties:<br>
        /// `id`, `status`, `file_size`, `recording_type`, and `play_url`.
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// The recording file ID. Included in the response of general query.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The meeting ID.
        /// </summary>
        public string MeetingId { get; set; }

        /// <summary>
        /// The URL using which a recording file can be played.
        /// </summary>
        public string PlayUrl { get; set; }

        /// <summary>
        /// The recording end time. Response in general query.
        /// </summary>
        public string RecordingEnd { get; set; }

        /// <summary>
        /// The recording start time.
        /// </summary>
        public string RecordingStart { get; set; }

        /// <summary>
        /// The recording type. The value of this field can be one of the
        /// following:<br>`shared_screen_with_speaker_view(CC)`<br>`shared_screen_with_speaker_view`<br>`shared_screen_with_gallery_view`<br>`speaker_view`<br>`gallery_view`<br>`shared_screen`<br>`audio_only`<br>`audio_transcript`<br>`chat_file`<br>`TIMELINE`
        /// </summary>
        public string RecordingType { get; set; }

        /// <summary>
        /// The recording status.
        /// </summary>
        public Status? Status { get; set; }
    }
}