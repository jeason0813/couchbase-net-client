﻿using System;
using System.Collections.Generic;

namespace Couchbase.Authentication
{
    [Obsolete("Please use IAuthenticator instead.")]
    public interface IClusterCredentials
    {
        string ClusterPassword { set; }

        string ClusterUsername { set; }

        Dictionary<string, string> BucketCredentials { get; set; }

        void AddBucket(string bucketPassword, string bucketName);

        Dictionary<string, string> GetCredentials(AuthContext context, string bucketName = null);
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2015 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion
