namespace Razmestim100.Site._2019

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI
open WebSharper.UI.Client
open WebSharper.UI.Html
open WebSharper.UI.Templating
open WebSharper.JQuery

//[<JavaScript>]
//module Client =
    //type MainTemplate = Template<"Main.html", ClientLoad.FromDocument>

    //type GeoData =
    //    {
    //        region : string
    //    }
    //type TranslateData = 
    //    {
    //        code : int
    //        text : string array
    //    }

    //let GeoLabel () =
        //JS.Alert "GeoLabel starting"

        //let geoUrl = "https://ipinfo.io/json"
        //let translateUrlBase = "https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20161217T145250Z.b0aa07b812f15935.2fa3526783e30dd6bdde3729d9e48e97b97208a0&lang=en-ru&text="  

        //JQuery.GetJSON(geoUrl, fun (data, _) ->
        //    let geo = As<GeoData> data

        //    if geo.region.Length > 0 then
        //        let translateUrl = translateUrlBase + geo.region

        //        JQuery.GetJSON(translateUrl, fun (data, _) ->
        //            let translate = As<TranslateData> data

        //            if translate.code = 200 && translate.text.Length > 0
        //            then
        //                let current = translate.text.[0]

        //                JS.Window.LocalStorage.SetItem ("region", current)

        //                let geoLabelDoc = MainTemplate.GeoLabelTemplate().Region(current).Doc()

        //                MainTemplate().GeoLabel(geoLabelDoc).Bind()
        //        )|> ignore
        //)|> ignore

    ////[<SPAEntryPoint>]
    //let Main () = 
        //GeoLabel ()
