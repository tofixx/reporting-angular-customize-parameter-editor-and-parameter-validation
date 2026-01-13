using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;

namespace CustomParameterEditorAngularExample.PredefinedReports
{
  public partial class CustomParameterReport : DevExpress.XtraReports.UI.XtraReport
  {
    public CustomParameterReport()
    {
      InitializeComponent();

      this.BeforePrint += ValidateParameters;

      // 
      // customMailParameter
      // 
      Parameter customMailParameter = new Parameter
      {
        Description = "Custom Email Parameter",
        Name = "customMailParameter",
        ValueInfo = "SampleMail@example.com",
        Type = typeof(CustomParameterType),
        Visible = true,
        Enabled = true
      };

      this.Parameters.Add(customMailParameter);

      this.label2.ExpressionBindings.AddRange(new ExpressionBinding[] {
            new ExpressionBinding("BeforePrint", "Text", "?customMailParameter") });
    }

    private void ValidateParameters(object sender, CancelEventArgs e)
    {
      // validate all parameters before printing here again as view validation gives no guarantee
      foreach (var parameter in Parameters)
      {
        // Validation 1: Check required parameters with lookup values
        if (parameter.AllowNull != true)
        {
          // Check if parameter has a value selected
          if (parameter.Value == null ||
              (parameter.MultiValue && parameter.Value is System.Collections.IEnumerable enumerable && !enumerable.GetEnumerator().MoveNext()))
          {
            throw new InvalidOperationException($"Parameter '{parameter.Description ?? parameter.Name}': Mindestens ein Eintrag muss ausgewählt werden.");
          }
        }

      }
    }
  }
}
