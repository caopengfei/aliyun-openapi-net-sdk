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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ModifyCommonBandwidthPackagePayTypeRequest : RpcAcsRequest<ModifyCommonBandwidthPackagePayTypeResponse>
    {
        public ModifyCommonBandwidthPackagePayTypeRequest()
            : base("Vpc", "2016-04-28", "ModifyCommonBandwidthPackagePayType", "vpc", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string bandwidthPackageId;

		private bool? autoPay;

		private string resourceOwnerAccount;

		private string bandwidth;

		private string ownerAccount;

		private long? ownerId;

		private int? duration;

		private string kbpsBandwidth;

		private string regionId;

		private long? resourceUid;

		private string action;

		private string resourceBid;

		private string payType;

		private string pricingCycle;

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

		public string BandwidthPackageId
		{
			get
			{
				return bandwidthPackageId;
			}
			set	
			{
				bandwidthPackageId = value;
				DictionaryUtil.Add(QueryParameters, "BandwidthPackageId", value);
			}
		}

		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value.ToString());
			}
		}

		public string KbpsBandwidth
		{
			get
			{
				return kbpsBandwidth;
			}
			set	
			{
				kbpsBandwidth = value;
				DictionaryUtil.Add(QueryParameters, "KbpsBandwidth", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public long? ResourceUid
		{
			get
			{
				return resourceUid;
			}
			set	
			{
				resourceUid = value;
				DictionaryUtil.Add(QueryParameters, "ResourceUid", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string ResourceBid
		{
			get
			{
				return resourceBid;
			}
			set	
			{
				resourceBid = value;
				DictionaryUtil.Add(QueryParameters, "ResourceBid", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

		public string PricingCycle
		{
			get
			{
				return pricingCycle;
			}
			set	
			{
				pricingCycle = value;
				DictionaryUtil.Add(QueryParameters, "PricingCycle", value);
			}
		}

        public override ModifyCommonBandwidthPackagePayTypeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyCommonBandwidthPackagePayTypeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}