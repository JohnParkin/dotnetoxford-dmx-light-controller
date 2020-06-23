This directory contains helper scripts. Below is a description of each...

# CreateAzureResources.linq

This is a LINQPad script which uses the [Azure Management SDK](https://github.com/Azure/azure-libraries-for-net) to create the resources in Azure required for this demo. Note that to use this script, you'll need to generate a file called `azureauth` by running the `CreateAzureAuthFile.ps1` script. That script requires the [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest) tools to be installed, and for you to have used it to authenticate with Azure and set your target subscription as the currently active one.
