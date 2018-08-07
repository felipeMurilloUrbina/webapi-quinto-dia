using System;
using System.Reflection;

namespace Avika.Forum.WebApiAuthorization.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}