using GovUkDesignSystem.GovUkDesignSystemComponents;
using GovUkDesignSystem.GovUkDesignSystemComponents.SubComponents;
using GovUkDesignSystem.HtmlGenerators;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GovUkDesignSystem
{
    public static class GovUkHtmlHelperExtensions
    {

        public static async Task<IHtmlContent> GovUkAccordion(
            this IHtmlHelper htmlHelper,
            AccordionViewModel accordionViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Accordion.cshtml", accordionViewModel);
        }

        public static async Task<IHtmlContent> GovUkBackLink(
            this IHtmlHelper htmlHelper,
            BackLinkViewModel backLinkViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/BackLink.cshtml", backLinkViewModel);
        }

        public static async Task<IHtmlContent> GovUkBreadcrumbs(
            this IHtmlHelper htmlHelper,
            BreadcrumbsViewModel breadcrumbsViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Breadcrumbs.cshtml", breadcrumbsViewModel);
        }

        public static async Task<IHtmlContent> GovUkButton(
            this IHtmlHelper htmlHelper,
            ButtonViewModel buttonViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Button.cshtml", buttonViewModel);
        }

        public static async Task<IHtmlContent> GovUkCharacterCount(
            this IHtmlHelper htmlHelper,
            CharacterCountViewModel characterCountViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/CharacterCount.cshtml", characterCountViewModel);
        }

        public static async Task<IHtmlContent> GovUkCharacterCountFor<TModel>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, string>> propertyLambdaExpression,
            int? rows = null,
            LabelViewModel labelOptions = null,
            HintViewModel hintOptions = null,
            FormGroupViewModel formGroupOptions = null)
            where TModel : class
        {
            return await CharacterCountHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyLambdaExpression,
                rows,
                labelOptions,
                hintOptions,
                formGroupOptions);
        }

        public static async Task<IHtmlContent> GovUkCheckboxes(
            this IHtmlHelper htmlHelper,
            CheckboxesViewModel checkboxesViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Checkboxes.cshtml", checkboxesViewModel);
        }

        public static async Task<IHtmlContent> GovUkCheckboxesFor<TModel, TEnum>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, List<TEnum>>> propertyLambdaExpression,
            FieldsetViewModel fieldsetOptions = null,
            HintViewModel hintOptions = null,
            Dictionary<TEnum, Conditional> conditionalOptions = null
            )
            where TModel : class
            where TEnum : Enum
        {
            return await CheckboxesHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyLambdaExpression,
                fieldsetOptions,
                hintOptions,
                conditionalOptions);
        }

        public static async Task<IHtmlContent> GovUkCheckboxItem(
            this IHtmlHelper htmlHelper,
            CheckboxItemViewModel checkboxItemViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/CheckboxItem.cshtml", checkboxItemViewModel);
        }

        public static async Task<IHtmlContent> GovUkDateInput(
            this IHtmlHelper htmlHelper,
            DateInputViewModel dateInputViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/DateInput.cshtml", dateInputViewModel);
        }

        /// <summary>
        /// This doesn't work for more than three items and only if they have ids 'day', 'month', and 'year'.
        /// <returns></returns>
        public static async Task<IHtmlContent> GovUkDateInputFor<TModel>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, DateTime?>> propertyLambdaExpression,
            string classes = null,
            LabelViewModel labelOptions = null,
            HintViewModel hintOptions = null,
            FieldsetViewModel fieldsetOptions = null,
            FormGroupViewModel formGroupOptions = null,
            Dictionary<string, string> attributes = null
            )
            where TModel : class
        {
            return await DateInputHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyLambdaExpression,
                classes,
                labelOptions,
                hintOptions,
                fieldsetOptions,
                formGroupOptions,
                attributes);
        }

        public static async Task<IHtmlContent> GovUkDetails(
            this IHtmlHelper htmlHelper,
            DetailsViewModel detailsViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Details.cshtml", detailsViewModel);
        }

        public static async Task<IHtmlContent> GovUkErrorMessage(
            this IHtmlHelper htmlHelper,
            ErrorMessageViewModel errorMessageViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/ErrorMessage.cshtml", errorMessageViewModel);
        }

        public static async Task<IHtmlContent> GovUkErrorSummary(
            this IHtmlHelper htmlHelper,
            ErrorSummaryViewModel errorSummaryViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/ErrorSummary.cshtml", errorSummaryViewModel);
        }

        public static async Task<IHtmlContent> GovUkErrorSummary(
            this IHtmlHelper htmlHelper,
            ModelStateDictionary modelState,
            string[] optionalOrderOfPropertyNamesInTheView = null)
        {
            // Give 'optionalOrderOfPropertiesInTheView' a default value (of an empty array)
            var orderOfPropertyNamesInTheView = optionalOrderOfPropertyNamesInTheView ?? new string[0];

            return await ErrorSummaryHtmlGenerator.GenerateHtml(htmlHelper, modelState, orderOfPropertyNamesInTheView);
        }

        public static async Task<IHtmlContent> GovUkFieldset(
            this IHtmlHelper htmlHelper,
            FieldsetViewModel fieldsetViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Fieldset.cshtml", fieldsetViewModel);
        }

        public static async Task<IHtmlContent> GovUkFooter(
            this IHtmlHelper htmlHelper,
            FooterViewModel footerViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Footer.cshtml", footerViewModel);
        }

        public static async Task<IHtmlContent> GovUkHeader(
            this IHtmlHelper htmlHelper,
            HeaderViewModel headerViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Header.cshtml", headerViewModel);
        }

        public static async Task<IHtmlContent> GovUkHint(
            this IHtmlHelper htmlHelper,
            HintViewModel hintViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Hint.cshtml", hintViewModel);
        }

        public static async Task<IHtmlContent> GovUkHtmlText(
            this IHtmlHelper htmlHelper,
            IHtmlText htmlText)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/SubComponents/HtmlText.cshtml", htmlText);
        }

        public static async Task<IHtmlContent> GovUkInsetText(
            this IHtmlHelper htmlHelper,
            InsetTextViewModel insetTextViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/InsetText.cshtml", insetTextViewModel);
        }

        public static async Task<IHtmlContent> GovUkItem(
            this IHtmlHelper htmlHelper,
            ItemViewModel itemViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Item.cshtml", itemViewModel);
        }

        public static async Task<IHtmlContent> GovUkItemSet(
            this IHtmlHelper htmlHelper,
            ItemSetViewModel itemSetViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/ItemSet.cshtml", itemSetViewModel);
        }

        public static async Task<IHtmlContent> GovUkLabel(
            this IHtmlHelper htmlHelper,
            LabelViewModel labelViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Label.cshtml", labelViewModel);
        }

        public static async Task<IHtmlContent> GovUkLegend(
            this IHtmlHelper htmlHelper,
            LegendViewModel legendViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Legend.cshtml", legendViewModel);
        }

        public static async Task<IHtmlContent> GovUkPanel(
            this IHtmlHelper htmlHelper,
            PanelViewModel panelViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Panel.cshtml", panelViewModel);
        }

        public static async Task<IHtmlContent> GovUkPhaseBanner(
            this IHtmlHelper htmlHelper,
            PhaseBannerViewModel phaseBannerViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/PhaseBanner.cshtml", phaseBannerViewModel);
        }

        public static async Task<IHtmlContent> GovUkRadiosFor<TModel, TEnum>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TEnum?>> propertyLambdaExpression,
            FieldsetViewModel fieldsetOptions = null,
            HintViewModel hintOptions = null,
            string classes = null)
            where TModel : class
            where TEnum : struct, Enum
        {
            return await RadiosHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyLambdaExpression,
                fieldsetOptions,
                hintOptions,
                classes);
        }

        public static async Task<IHtmlContent> GovUkRadioItem(
            this IHtmlHelper htmlHelper,
            RadioItemViewModel radioItemViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/RadioItem.cshtml", radioItemViewModel);
        }

        public static async Task<IHtmlContent> GovUkSummaryList(
            this IHtmlHelper htmlHelper,
            SummaryListViewModel summaryListViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/SummaryList.cshtml", summaryListViewModel);
        }

        public static async Task<IHtmlContent> GovUkTable(
            this IHtmlHelper htmlHelper,
            TableGovUkViewModel tableViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Table.cshtml", tableViewModel);
        }

        public static async Task<IHtmlContent> GovUkTabs(
            this IHtmlHelper htmlHelper,
            TabsViewModel tabsViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Tabs.cshtml", tabsViewModel);
        }

        public static async Task<IHtmlContent> GovUkTag(
            this IHtmlHelper htmlHelper,
            TagViewModel tagViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/Tag.cshtml", tagViewModel);
        }

        public static async Task<IHtmlContent> GovUkTextArea(
            this IHtmlHelper htmlHelper,
            TextAreaViewModel textAreaViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/TextArea.cshtml", textAreaViewModel);
        }

        public static async Task<IHtmlContent> GovUkTextAreaFor<TModel>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, string>> propertyLambdaExpression,
            int? rows = null,
            LabelViewModel labelOptions = null,
            HintViewModel hintOptions = null,
            FormGroupViewModel formGroupOptions = null)
            where TModel : class
        {
            return await TextAreaHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyLambdaExpression,
                rows,
                labelOptions,
                hintOptions,
                formGroupOptions);
        }

        public static async Task<IHtmlContent> GovUkTextInput(
            this IHtmlHelper htmlHelper,
            TextInputViewModel textInputViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/TextInput.cshtml", textInputViewModel);
        }

        public static async Task<IHtmlContent> GovUkTextInputFor<TModel>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, string>> propertyExpression,
            LabelViewModel labelOptions = null,
            HintViewModel hintOptions = null,
            FormGroupViewModel formGroupOptions = null,
            string classes = null,
            TextInputAppendixViewModel textInputAppendix = null)
            where TModel : class
        {
            return await TextInputHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyExpression,
                labelOptions,
                hintOptions,
                formGroupOptions,
                classes,
                textInputAppendix);
        }

        public static async Task<IHtmlContent> GovUkTextInputFor<TModel>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, int?>> propertyExpression,
            LabelViewModel labelOptions = null,
            HintViewModel hintOptions = null,
            FormGroupViewModel formGroupOptions = null,
            string classes = null,
            TextInputAppendixViewModel textInputAppendix = null)
            where TModel : class
        {
            return await TextInputHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyExpression,
                labelOptions,
                hintOptions,
                formGroupOptions,
                classes,
                textInputAppendix);
        }

        public static async Task<IHtmlContent> GovUkTextInputFor<TModel>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, decimal?>> propertyExpression,
            LabelViewModel labelOptions = null,
            HintViewModel hintOptions = null,
            FormGroupViewModel formGroupOptions = null,
            string classes = null,
            TextInputAppendixViewModel textInputAppendix = null)
            where TModel : class
        {
            return await TextInputHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyExpression,
                labelOptions,
                hintOptions,
                formGroupOptions,
                classes,
                textInputAppendix);
        }

        public static async Task<IHtmlContent> GovUkFileUpload(
            this IHtmlHelper htmlHelper,
            FileUploadViewModel fileUploadViewModel)
        {
            return await htmlHelper.PartialAsync("/GovUkDesignSystemComponents/FileUpload.cshtml", fileUploadViewModel);
        }

        public static async Task<IHtmlContent> GovUkFileUploadFor<TModel>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, IFormFile>> propertyExpression,
            LabelViewModel labelOptions = null,
            HintViewModel hintOptions = null,
            FormGroupViewModel formGroupOptions = null,
            string classes = null)
            where TModel : class
        {
            return await FileUploadHtmlGenerator.GenerateHtml(
                htmlHelper,
                propertyExpression,
                labelOptions,
                hintOptions,
                formGroupOptions,
                classes);
        }
    }
}
