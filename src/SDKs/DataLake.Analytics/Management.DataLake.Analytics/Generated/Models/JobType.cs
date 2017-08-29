// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobType
    {
        [EnumMember(Value = "USql")]
        USql,
        [EnumMember(Value = "Hive")]
        Hive
    }
    internal static class JobTypeEnumExtension
    {
        internal static string ToSerializedValue(this JobType? value)  =>
            value == null ? null : ((JobType)value).ToSerializedValue();

        internal static string ToSerializedValue(this JobType value)
        {
            switch( value )
            {
                case JobType.USql:
                    return "USql";
                case JobType.Hive:
                    return "Hive";
            }
            return null;
        }

        internal static JobType? ParseJobType(this string value)
        {
            switch( value )
            {
                case "USql":
                    return JobType.USql;
                case "Hive":
                    return JobType.Hive;
            }
            return null;
        }
    }
}