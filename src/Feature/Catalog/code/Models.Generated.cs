//    Copyright 2020 EPAM Systems, Inc.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Rainbow JS CodeGeneration.
//     (https://github.com/asmagin/rainbow-js-codegeneration)
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCA.Feature.Catalog.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Configuration;
    using Glass.Mapper.Sc.Fields;
    using Sitecore.Globalization;
    using Sitecore.Data;
    using Sitecore.Data.Items;

    using System.CodeDom.Compiler;
    using HCA.Foundation.GlassMapper.Models;


    /// <summary>
    /// IProductColorMapping Interface
    /// <para>Path: /sitecore/templates/HCA/Feature/Catalog/Settings/Product Color Mapping</para>
    /// <para>ID: ca4b8e4a-bfec-474a-8a85-e7df2d9c1404</para>
    /// </summary>
    [SitecoreType(TemplateId="ca4b8e4a-bfec-474a-8a85-e7df2d9c1404")]
    public partial interface IProductColorMapping: IGlassBase
    {

        /// <summary>
        /// The Color HEX field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 634fdabf-59c5-4b31-9878-3c370fea110f</para>
        /// </summary>
        [SitecoreField("Color HEX")]
        string ColorHEX {get; set;}

        /// <summary>
        /// The Color Name field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: ba711f5f-bc6f-4bb0-9628-1f135ec399fa</para>
        /// </summary>
        [SitecoreField("Color Name")]
        string ColorName {get; set;}

    }


    /// <summary>
    /// ProductColorMapping Class
    /// <para>Path: /sitecore/templates/HCA/Feature/Catalog/Settings/Product Color Mapping</para>
    /// <para>ID: ca4b8e4a-bfec-474a-8a85-e7df2d9c1404</para>
    /// </summary>
    [SitecoreType(TemplateId="ca4b8e4a-bfec-474a-8a85-e7df2d9c1404")]
    public partial class ProductColorMapping: GlassBase, IProductColorMapping
    {
        /// <summary>
        /// The TemplateId string for /sitecore/templates/HCA/Feature/Catalog/Settings/Product Color Mapping
        /// </summary>
        public const string TemplateId = "ca4b8e4a-bfec-474a-8a85-e7df2d9c1404";

        /// <summary>
        /// The Color HEX field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 634fdabf-59c5-4b31-9878-3c370fea110f</para>
        /// </summary>
        [SitecoreField("Color HEX")]
        public virtual string ColorHEX {get; set;}
        public const string ColorHEXFieldId = "634fdabf-59c5-4b31-9878-3c370fea110f";
        public const string ColorHEXFieldName = "Color HEX";

        /// <summary>
        /// The Color Name field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: ba711f5f-bc6f-4bb0-9628-1f135ec399fa</para>
        /// </summary>
        [SitecoreField("Color Name")]
        public virtual string ColorName {get; set;}
        public const string ColorNameFieldId = "ba711f5f-bc6f-4bb0-9628-1f135ec399fa";
        public const string ColorNameFieldName = "Color Name";

    }


    /// <summary>
    /// IProductColorMappingFolder Interface
    /// <para>Path: /sitecore/templates/HCA/Feature/Catalog/Settings/Product Color Mapping Folder</para>
    /// <para>ID: 93687745-63f3-4022-8cb0-29848c918a18</para>
    /// </summary>
    [SitecoreType(TemplateId="93687745-63f3-4022-8cb0-29848c918a18")]
    public partial interface IProductColorMappingFolder: IGlassBase
    {

    }


    /// <summary>
    /// ProductColorMappingFolder Class
    /// <para>Path: /sitecore/templates/HCA/Feature/Catalog/Settings/Product Color Mapping Folder</para>
    /// <para>ID: 93687745-63f3-4022-8cb0-29848c918a18</para>
    /// </summary>
    [SitecoreType(TemplateId="93687745-63f3-4022-8cb0-29848c918a18")]
    public partial class ProductColorMappingFolder: GlassBase, IProductColorMappingFolder
    {
        /// <summary>
        /// The TemplateId string for /sitecore/templates/HCA/Feature/Catalog/Settings/Product Color Mapping Folder
        /// </summary>
        public const string TemplateId = "93687745-63f3-4022-8cb0-29848c918a18";

    }

}