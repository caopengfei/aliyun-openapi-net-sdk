/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20151101;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
    public class OpsCreateImageRequest : RpcAcsRequest<OpsCreateImageResponse>
    {
        public OpsCreateImageRequest()
            : base("Ecs", "2015-11-01", "OpsCreateImage")
        {
        }

		private string regionNo;

		private string snapshotId;

		private long? resourceOwnerId;

		private string version;

		private string remark;

		private string imageName;

		private bool? isPublic;

		public string RegionNo
		{
			get
			{
				return regionNo;
			}
			set	
			{
				regionNo = value;
				DictionaryUtil.Add(QueryParameters, "RegionNo", value);
			}
		}

		public string SnapshotId
		{
			get
			{
				return snapshotId;
			}
			set	
			{
				snapshotId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotId", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
				DictionaryUtil.Add(QueryParameters, "Version", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
			}
		}

		public bool? IsPublic
		{
			get
			{
				return isPublic;
			}
			set	
			{
				isPublic = value;
				DictionaryUtil.Add(QueryParameters, "IsPublic", value.ToString());
			}
		}

        public override OpsCreateImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsCreateImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}