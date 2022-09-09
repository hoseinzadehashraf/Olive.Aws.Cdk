﻿using Amazon.CDK.AWS.Lambda;

namespace Olive.Aws.Cdk
{
    public static class RuntimeFactory
    {
        public static Runtime Create(string customRuntime)
        {
            return customRuntime switch
            {
                "DOTNET_CORE_NODE_JS" => CreateDotNetCoreNodeJsRuntime(),
                _ => Runtime.DOTNET_CORE_3_1
            };
        }

        private static Runtime CreateDotNetCoreNodeJsRuntime()
        {
            return new Runtime("DOTNET_CORE_NODE_JS", RuntimeFamily.DOTNET_CORE,
                new LambdaRuntimeProps
                {
                    BundlingDockerImage = ""
                });
        }
    }
}