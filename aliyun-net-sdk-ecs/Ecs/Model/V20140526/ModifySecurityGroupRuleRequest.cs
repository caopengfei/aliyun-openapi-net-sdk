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
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifySecurityGroupRuleRequest : RpcAcsRequest<ModifySecurityGroupRuleResponse>
    {
        public ModifySecurityGroupRuleRequest()
            : base("Ecs", "2014-05-26", "ModifySecurityGroupRule")
        {
        }

		private string nicType;

		private long? resourceOwnerId;

		private string portRange;

		private string resourceOwnerAccount;

		private string ipProtocol;

		private string clientToken;

		private string sourceCidrIp;

		private string ownerAccount;

		private string securityGroupId;

		private long? ownerId;

		private int? priority;

		private string sourceGroupOwnerAccount;

		private string regionId;

		private string sourceGroupId;

		private string action;

		private string policy;

		public string NicType
		{
			get
			{
				return nicType;
			}
			set	
			{
				nicType = value;
				DictionaryUtil.Add(QueryParameters, "NicType", value);
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

		public string PortRange
		{
			get
			{
				return portRange;
			}
			set	
			{
				portRange = value;
				DictionaryUtil.Add(QueryParameters, "PortRange", value);
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

		public string IpProtocol
		{
			get
			{
				return ipProtocol;
			}
			set	
			{
				ipProtocol = value;
				DictionaryUtil.Add(QueryParameters, "IpProtocol", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string SourceCidrIp
		{
			get
			{
				return sourceCidrIp;
			}
			set	
			{
				sourceCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceCidrIp", value);
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

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
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

		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value.ToString());
			}
		}

		public string SourceGroupOwnerAccount
		{
			get
			{
				return sourceGroupOwnerAccount;
			}
			set	
			{
				sourceGroupOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "SourceGroupOwnerAccount", value);
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

		public string SourceGroupId
		{
			get
			{
				return sourceGroupId;
			}
			set	
			{
				sourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SourceGroupId", value);
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

		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
				DictionaryUtil.Add(QueryParameters, "Policy", value);
			}
		}

        public override ModifySecurityGroupRuleResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifySecurityGroupRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}