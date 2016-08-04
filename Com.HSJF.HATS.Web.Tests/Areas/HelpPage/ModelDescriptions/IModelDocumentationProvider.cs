using System;
using System.Reflection;

namespace Com.HSJF.HATS.Web.Tests.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}