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
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class ModifyVServerGroupBackendServersResponse : AcsResponse
	{

		private string vServerGroupId;

		private List<BackendServer> backendServers;

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
			}
		}

		public List<BackendServer> BackendServers
		{
			get
			{
				return backendServers;
			}
			set	
			{
				backendServers = value;
			}
		}

		public class BackendServer{

			private string serverId;

			private int? port;

			private int? weight;

			public string ServerId
			{
				get
				{
					return serverId;
				}
				set	
				{
					serverId = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public int? Weight
			{
				get
				{
					return weight;
				}
				set	
				{
					weight = value;
				}
			}
		}
	}
}