using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker 
{

    /// <summary>
    /// FetchWorkerStatisticsOptions
    /// </summary>
    public class FetchWorkerStatisticsOptions : IOptions<WorkerStatisticsResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string WorkerSid { get; }
        /// <summary>
        /// The minutes
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// The start_date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The end_date
        /// </summary>
        public DateTime? EndDate { get; set; }
    
        /// <summary>
        /// Construct a new FetchWorkerStatisticsOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        public FetchWorkerStatisticsOptions(string workspaceSid, string workerSid)
        {
            WorkspaceSid = workspaceSid;
            WorkerSid = workerSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.Value.ToString()));
            }
            
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd'T'HH:mm:ss")));
            }
            
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd'T'HH:mm:ss")));
            }
            
            return p;
        }
    }

}