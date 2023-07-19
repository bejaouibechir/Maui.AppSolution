namespace Maui.App
{
    public class PriceTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Template1 { get; set; }
        public DataTemplate Template2 { get; set; }


        protected override DataTemplate 
            OnSelectTemplate(object item, BindableObject container)
        {
            Product product = (Product)item;
            if (product.Price > 3000)
                return Template1;
            else return Template2;
        }
    }
}
