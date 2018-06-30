namespace SampleGrid

open System
open Xamarin.Forms
open Xamarin.Forms.Xaml

type MainPage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<MainPage>)

    let button = base.FindByName<Button>("button")
    let label = base.FindByName<Label>("label")

    member this.OnClicked( sender : Object, args : EventArgs) = 
       do label.Text <- "Hello, again."
