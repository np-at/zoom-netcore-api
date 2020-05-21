using System;

namespace AndcultureCode.ZoomClient.Models.Recordings
{
    /// <summary>
    /// List of recordings.
    /// </summary>
    public partial class ListRecordings
    {
        /// <summary>
        /// Start Date.
        /// </summary>
        public DateTimeOffset? From { get; set; }

        /// <summary>
        /// List of recordings.
        /// </summary>
        public MeetingElement[] Meetings { get; set; }

        /// <summary>
        /// The next page token is used to paginate through large result sets. A next page token will
        /// be returned whenever the set of available results exceeds the current page size. The
        /// expiration period for this token is 15 minutes.
        /// </summary>
        public string NextPageToken { get; set; }

        /// <summary>
        /// The number of pages returned for the request made.
        /// </summary>
        public long? PageCount { get; set; }

        /// <summary>
        /// The number of records returned within a single API call.
        /// </summary>
        public long? PageSize { get; set; }

        /// <summary>
        /// End Date.
        /// </summary>
        public DateTimeOffset? To { get; set; }

        /// <summary>
        /// The number of all records available across pages.
        /// </summary>
        public long? TotalRecords { get; set; }
    }
}