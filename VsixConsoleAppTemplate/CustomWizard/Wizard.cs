using System.Collections.Generic;
using System.Diagnostics;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace CustomWizard
{
    public class Wizard : IWizard {
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            replacementsDictionary.Add("$companynamespace$", "Infomedia");
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            Debug.WriteLine("ShouldAddProjectItem");
            return true;
        }

        public void RunFinished()
        {
            Debug.WriteLine("RunFinished");
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            Debug.WriteLine("BeforeOpeningFile");
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            Debug.WriteLine("ProjectItemFinishedGenerating");
        }

        public void ProjectFinishedGenerating(Project project)
        {
            Debug.WriteLine("ProjectFinishedGenerating");
        }
    }
}