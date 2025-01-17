using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

public abstract class BasePage 
{
    protected IPage Page => TestHooks.Page;
    // protected IPage Page { get; private set; }

    // protected BasePage(IPage page){
    //     Page = page;
    // }

    public async Task NavigateToUrl(String url) 
    {
        await Page.GotoAsync(url);
    }

    public async Task ClickElement(string Locator)
    {  
        await Page.ClickAsync(Locator);
    }

    public async Task FillInTextbox(string Locator,string InputText)
    {
        await Page.FillAsync(Locator, InputText);
    }

    public async Task ClickEnter(string Locator, string Key)
    {
        await Page.PressAsync(Locator, Key);
    }
    

}
