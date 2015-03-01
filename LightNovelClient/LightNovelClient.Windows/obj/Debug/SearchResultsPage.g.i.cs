﻿

#pragma checksum "C:\Users\Yupeng\Source\Workspaces\LightNovelClientWindows\LightNovelClient\LightNovelClient.Windows\SearchResultsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81A836FB69FF16251F3E15B0FBCCD92A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightNovel
{
    partial class SearchResultsPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Page pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource resultsViewSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource filtersViewSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid resultsPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock noResultsTextBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ProgressBar progressBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button backButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock resultText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox queryText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid typicalPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ItemsControl filtersItemsControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.SemanticZoom resultsView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.GridView resultsZoomedInView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.GridView resultsZoomedOutView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualStateGroup ResultStates; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState Searching; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState ResultsFound; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState NoResultsFound; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState ErrorInSearch; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///SearchResultsPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::Windows.UI.Xaml.Controls.Page)this.FindName("pageRoot");
            resultsViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("resultsViewSource");
            filtersViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("filtersViewSource");
            resultsPanel = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("resultsPanel");
            noResultsTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("noResultsTextBlock");
            progressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)this.FindName("progressBar");
            backButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            resultText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("resultText");
            queryText = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("queryText");
            typicalPanel = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("typicalPanel");
            filtersItemsControl = (global::Windows.UI.Xaml.Controls.ItemsControl)this.FindName("filtersItemsControl");
            resultsView = (global::Windows.UI.Xaml.Controls.SemanticZoom)this.FindName("resultsView");
            resultsZoomedInView = (global::Windows.UI.Xaml.Controls.GridView)this.FindName("resultsZoomedInView");
            resultsZoomedOutView = (global::Windows.UI.Xaml.Controls.GridView)this.FindName("resultsZoomedOutView");
            ResultStates = (global::Windows.UI.Xaml.VisualStateGroup)this.FindName("ResultStates");
            Searching = (global::Windows.UI.Xaml.VisualState)this.FindName("Searching");
            ResultsFound = (global::Windows.UI.Xaml.VisualState)this.FindName("ResultsFound");
            NoResultsFound = (global::Windows.UI.Xaml.VisualState)this.FindName("NoResultsFound");
            ErrorInSearch = (global::Windows.UI.Xaml.VisualState)this.FindName("ErrorInSearch");
        }
    }
}



