using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.CartDiscounts
{
    public enum SelectionMode
    {
        [Description("Cheapest")]
        Cheapest,

        [Description("MostExpensive")]
        MostExpensive
    }

    public class SelectionModeWrapper : ISelectionMode
    {
        public string JsonName { get; internal set; }
        public SelectionMode? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(ISelectionMode), "FindEnum")]
    public interface ISelectionMode : IJsonName
    {
        public static ISelectionMode Cheapest = new SelectionModeWrapper
        { Value = SelectionMode.Cheapest, JsonName = "Cheapest" };

        public static ISelectionMode MostExpensive = new SelectionModeWrapper
        { Value = SelectionMode.MostExpensive, JsonName = "MostExpensive" };

        SelectionMode? Value { get; }

        static ISelectionMode[] Values()
        {
            return new[]
            {
                 Cheapest ,
                 MostExpensive
             };
        }
        static ISelectionMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SelectionModeWrapper() { JsonName = value };
        }
    }
}
