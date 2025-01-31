﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace DataExportSales.Models
{
    public partial class FailuresResponse
    {
        private string _failureBlobUri;
        
        /// <summary>
        /// Optional. Failure blob URI
        /// </summary>
        public string FailureBlobUri
        {
            get { return this._failureBlobUri; }
            set { this._failureBlobUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FailuresResponse class.
        /// </summary>
        public FailuresResponse()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken failureBlobUriValue = inputObject["FailureBlobUri"];
                if (failureBlobUriValue != null && failureBlobUriValue.Type != JTokenType.Null)
                {
                    this.FailureBlobUri = ((string)failureBlobUriValue);
                }
            }
        }
    }
}
