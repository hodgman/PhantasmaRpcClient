﻿using System.Collections.Generic;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetTokens : GenericRpcRequestResponseHandlerNoParam<List<TokenDto>>
    {
        public PhantasmaGetTokens(IClient client) : base(client, ApiMethods.getTokens.ToString()) { }
    }
}
