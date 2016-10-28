﻿#region Copyright
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2016
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

namespace Dnn.PersonaBar.Extensions.Components
{
    public enum PackageTypes
    {
        AuthSystem,
        AuthenticationSystem = AuthSystem,
        Auth_System = AuthSystem,
        CoreLanguagePack,
        Container,
        DashboardControl,
        ExtensionLanguagePack,
        JavascriptLibrary,
        Language,
        Library,
        Module,
        Provider,
        Skin,
        SkinObject,
        Widget,
    }

    public enum FileType
    {
        Control,
        Template,
        Manifest
    }

    public enum CreateModuleType
    {
        New,
        Control,
        Manifest
    }

    public class Constants
    {
        internal const string DefaultExtensionImage = "icon_extensions_32px.png";
        internal const string DefaultLanguageImage = "icon_languagePack.gif";
        internal const string DefaultAuthenicationImage = "icon_authentication.png";
        internal const string DefaultContainerImage = "icon_container.gif";
        internal const string DefaultSkinImage = "icon_skin.gif";
        internal const string DefaultProviderImage = "icon_provider.gif";
        internal const string DefaultLibraryImage = "icon_library.png";
        internal const string DefaultWidgetImage = "icon_widget.png";
        internal const string DefaultDashboardImage = "icon_dashboard.png";

        internal const string DnnAuthTypeName = "DNN";
        internal static string SharedResources = "~/admin/Dnn.PersonaBar/App_LocalResources/Extensions.resx";
    }
}
