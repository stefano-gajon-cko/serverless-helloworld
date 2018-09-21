# serverless-helloworld

##  simple aws lambda using serverless platform and .net core


1) Install serverless:

``` npm install -g serverless_ ```

2. Setup AWS Credentials

``` serverless config credentials --provider aws --key AKIAIOSFODNN7EXAMPLE --secret wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY ```

3. Create project

``` serverless  create --template aws-csharp --path myService ```

4. Add nuget package for api gateway models

``` dotnet add package Amazon.Lambda.APIGatewayEvents ```

