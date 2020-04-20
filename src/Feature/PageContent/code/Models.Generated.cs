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

namespace HCA.Feature.PageContent.Models
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
    /// IGridLayout Interface
    /// <para>Path: /sitecore/templates/HCA/Feature/PageContent/Rendering Parameters/Grid Layout</para>
    /// <para>ID: 61ed6a03-bbdb-4937-87fa-db5c53fc870c</para>
    /// </summary>
    [SitecoreType(TemplateId="61ed6a03-bbdb-4937-87fa-db5c53fc870c")]
    public partial interface IGridLayout: IGlassBase
    {

        /// <summary>
        /// The First Column Class field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: a10a1cf0-25e7-4b9f-a9ac-6d40de3cbe88</para>
        /// </summary>
        [SitecoreField("First Column Class")]
        string FirstColumnClass {get; set;}

        /// <summary>
        /// The Second Column Class field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 525bb442-fc9e-49dd-b557-52b833f0855d</para>
        /// </summary>
        [SitecoreField("Second Column Class")]
        string SecondColumnClass {get; set;}

        /// <summary>
        /// The Wrapper Class field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: b4386ac8-1f1b-49f3-adcb-264f5f595e52</para>
        /// </summary>
        [SitecoreField("Wrapper Class")]
        string WrapperClass {get; set;}

    }


    /// <summary>
    /// GridLayout Class
    /// <para>Path: /sitecore/templates/HCA/Feature/PageContent/Rendering Parameters/Grid Layout</para>
    /// <para>ID: 61ed6a03-bbdb-4937-87fa-db5c53fc870c</para>
    /// </summary>
    [SitecoreType(TemplateId="61ed6a03-bbdb-4937-87fa-db5c53fc870c")]
    public partial class GridLayout: GlassBase, IGridLayout
    {
        /// <summary>
        /// The TemplateId string for /sitecore/templates/HCA/Feature/PageContent/Rendering Parameters/Grid Layout
        /// </summary>
        public const string TemplateId = "61ed6a03-bbdb-4937-87fa-db5c53fc870c";

        /// <summary>
        /// The First Column Class field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: a10a1cf0-25e7-4b9f-a9ac-6d40de3cbe88</para>
        /// </summary>
        [SitecoreField("First Column Class")]
        public virtual string FirstColumnClass {get; set;}
        public const string FirstColumnClassFieldId = "a10a1cf0-25e7-4b9f-a9ac-6d40de3cbe88";
        public const string FirstColumnClassFieldName = "First Column Class";

        /// <summary>
        /// The Second Column Class field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 525bb442-fc9e-49dd-b557-52b833f0855d</para>
        /// </summary>
        [SitecoreField("Second Column Class")]
        public virtual string SecondColumnClass {get; set;}
        public const string SecondColumnClassFieldId = "525bb442-fc9e-49dd-b557-52b833f0855d";
        public const string SecondColumnClassFieldName = "Second Column Class";

        /// <summary>
        /// The Wrapper Class field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: b4386ac8-1f1b-49f3-adcb-264f5f595e52</para>
        /// </summary>
        [SitecoreField("Wrapper Class")]
        public virtual string WrapperClass {get; set;}
        public const string WrapperClassFieldId = "b4386ac8-1f1b-49f3-adcb-264f5f595e52";
        public const string WrapperClassFieldName = "Wrapper Class";

    }


    /// <summary>
    /// IHome Interface
    /// <para>Path: /sitecore/templates/HCA/Feature/PageContent/Home</para>
    /// <para>ID: 309e5f2f-cb6f-4e51-9a39-185be515f278</para>
    /// </summary>
    [SitecoreType(TemplateId="309e5f2f-cb6f-4e51-9a39-185be515f278")]
    public partial interface IHome: IGlassBase
    {

        /// <summary>
        /// The Main Promo Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: e61322f9-d70b-4a4b-ba2c-9359584e3362</para>
        /// </summary>
        [SitecoreField("Main Promo Image")]
        Image MainPromoImage {get; set;}

        /// <summary>
        /// The Main Promo Text field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 010272e8-caad-4046-9410-7d4c67e95bfb</para>
        /// </summary>
        [SitecoreField("Main Promo Text")]
        string MainPromoText {get; set;}

        /// <summary>
        /// The Promo A Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 0af1cec2-d257-44f8-a034-0c6624da9560</para>
        /// </summary>
        [SitecoreField("Promo A Image")]
        Image PromoAImage {get; set;}

        /// <summary>
        /// The Promo A Text field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 0612860c-f8be-428b-a432-e2aed3cb5776</para>
        /// </summary>
        [SitecoreField("Promo A Text")]
        string PromoAText {get; set;}

        /// <summary>
        /// The Promo B Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: d743c370-80dc-41d3-9c39-58b67dc9176c</para>
        /// </summary>
        [SitecoreField("Promo B Image")]
        Image PromoBImage {get; set;}

        /// <summary>
        /// The Promo C Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 4eeb0814-a262-45f1-beea-7956ed5e15a6</para>
        /// </summary>
        [SitecoreField("Promo C Image")]
        Image PromoCImage {get; set;}

        /// <summary>
        /// The Promo D Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 2c20de23-de06-4b1d-95f2-c39d911c1518</para>
        /// </summary>
        [SitecoreField("Promo D Image")]
        Image PromoDImage {get; set;}

        /// <summary>
        /// The Slider Header field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 6a98f330-5d79-480b-a700-ce29bd09570f</para>
        /// </summary>
        [SitecoreField("Slider Header")]
        string SliderHeader {get; set;}

        /// <summary>
        /// The Wide Promo Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 5567973b-f2f0-445c-b9b8-76d1d41c23ae</para>
        /// </summary>
        [SitecoreField("Wide Promo Image")]
        Image WidePromoImage {get; set;}

        /// <summary>
        /// The Wide Promo Text field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: bbca79c1-1f9e-43b3-a5d4-882f1a6b1a32</para>
        /// </summary>
        [SitecoreField("Wide Promo Text")]
        string WidePromoText {get; set;}

    }


    /// <summary>
    /// Home Class
    /// <para>Path: /sitecore/templates/HCA/Feature/PageContent/Home</para>
    /// <para>ID: 309e5f2f-cb6f-4e51-9a39-185be515f278</para>
    /// </summary>
    [SitecoreType(TemplateId="309e5f2f-cb6f-4e51-9a39-185be515f278")]
    public partial class Home: GlassBase, IHome
    {
        /// <summary>
        /// The TemplateId string for /sitecore/templates/HCA/Feature/PageContent/Home
        /// </summary>
        public const string TemplateId = "309e5f2f-cb6f-4e51-9a39-185be515f278";

        /// <summary>
        /// The Main Promo Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: e61322f9-d70b-4a4b-ba2c-9359584e3362</para>
        /// </summary>
        [SitecoreField("Main Promo Image")]
        public virtual Image MainPromoImage {get; set;}
        public const string MainPromoImageFieldId = "e61322f9-d70b-4a4b-ba2c-9359584e3362";
        public const string MainPromoImageFieldName = "Main Promo Image";

        /// <summary>
        /// The Main Promo Text field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 010272e8-caad-4046-9410-7d4c67e95bfb</para>
        /// </summary>
        [SitecoreField("Main Promo Text")]
        public virtual string MainPromoText {get; set;}
        public const string MainPromoTextFieldId = "010272e8-caad-4046-9410-7d4c67e95bfb";
        public const string MainPromoTextFieldName = "Main Promo Text";

        /// <summary>
        /// The Promo A Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 0af1cec2-d257-44f8-a034-0c6624da9560</para>
        /// </summary>
        [SitecoreField("Promo A Image")]
        public virtual Image PromoAImage {get; set;}
        public const string PromoAImageFieldId = "0af1cec2-d257-44f8-a034-0c6624da9560";
        public const string PromoAImageFieldName = "Promo A Image";

        /// <summary>
        /// The Promo A Text field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 0612860c-f8be-428b-a432-e2aed3cb5776</para>
        /// </summary>
        [SitecoreField("Promo A Text")]
        public virtual string PromoAText {get; set;}
        public const string PromoATextFieldId = "0612860c-f8be-428b-a432-e2aed3cb5776";
        public const string PromoATextFieldName = "Promo A Text";

        /// <summary>
        /// The Promo B Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: d743c370-80dc-41d3-9c39-58b67dc9176c</para>
        /// </summary>
        [SitecoreField("Promo B Image")]
        public virtual Image PromoBImage {get; set;}
        public const string PromoBImageFieldId = "d743c370-80dc-41d3-9c39-58b67dc9176c";
        public const string PromoBImageFieldName = "Promo B Image";

        /// <summary>
        /// The Promo C Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 4eeb0814-a262-45f1-beea-7956ed5e15a6</para>
        /// </summary>
        [SitecoreField("Promo C Image")]
        public virtual Image PromoCImage {get; set;}
        public const string PromoCImageFieldId = "4eeb0814-a262-45f1-beea-7956ed5e15a6";
        public const string PromoCImageFieldName = "Promo C Image";

        /// <summary>
        /// The Promo D Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 2c20de23-de06-4b1d-95f2-c39d911c1518</para>
        /// </summary>
        [SitecoreField("Promo D Image")]
        public virtual Image PromoDImage {get; set;}
        public const string PromoDImageFieldId = "2c20de23-de06-4b1d-95f2-c39d911c1518";
        public const string PromoDImageFieldName = "Promo D Image";

        /// <summary>
        /// The Slider Header field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 6a98f330-5d79-480b-a700-ce29bd09570f</para>
        /// </summary>
        [SitecoreField("Slider Header")]
        public virtual string SliderHeader {get; set;}
        public const string SliderHeaderFieldId = "6a98f330-5d79-480b-a700-ce29bd09570f";
        public const string SliderHeaderFieldName = "Slider Header";

        /// <summary>
        /// The Wide Promo Image field.
        /// <para>Field Type: Image</para>
        /// <para>Field ID: 5567973b-f2f0-445c-b9b8-76d1d41c23ae</para>
        /// </summary>
        [SitecoreField("Wide Promo Image")]
        public virtual Image WidePromoImage {get; set;}
        public const string WidePromoImageFieldId = "5567973b-f2f0-445c-b9b8-76d1d41c23ae";
        public const string WidePromoImageFieldName = "Wide Promo Image";

        /// <summary>
        /// The Wide Promo Text field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: bbca79c1-1f9e-43b3-a5d4-882f1a6b1a32</para>
        /// </summary>
        [SitecoreField("Wide Promo Text")]
        public virtual string WidePromoText {get; set;}
        public const string WidePromoTextFieldId = "bbca79c1-1f9e-43b3-a5d4-882f1a6b1a32";
        public const string WidePromoTextFieldName = "Wide Promo Text";

    }


    /// <summary>
    /// IHomeFolder Interface
    /// <para>Path: /sitecore/templates/HCA/Feature/PageContent/Home Folder</para>
    /// <para>ID: 3c486a78-0beb-48d9-8eb3-9a8f87b5e7e2</para>
    /// </summary>
    [SitecoreType(TemplateId="3c486a78-0beb-48d9-8eb3-9a8f87b5e7e2")]
    public partial interface IHomeFolder: IGlassBase
    {

    }


    /// <summary>
    /// HomeFolder Class
    /// <para>Path: /sitecore/templates/HCA/Feature/PageContent/Home Folder</para>
    /// <para>ID: 3c486a78-0beb-48d9-8eb3-9a8f87b5e7e2</para>
    /// </summary>
    [SitecoreType(TemplateId="3c486a78-0beb-48d9-8eb3-9a8f87b5e7e2")]
    public partial class HomeFolder: GlassBase, IHomeFolder
    {
        /// <summary>
        /// The TemplateId string for /sitecore/templates/HCA/Feature/PageContent/Home Folder
        /// </summary>
        public const string TemplateId = "3c486a78-0beb-48d9-8eb3-9a8f87b5e7e2";

    }

}