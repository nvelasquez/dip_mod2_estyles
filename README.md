# dip_mod2_estyles
Modulo Dos del Diplomado Xamarin Forms Uteco.

El presente repositorio corresponde al laboratorio trabajado en clases para el encuentro **no. 2** del **modulo 2** del diplomado de Desarrollo de aplicaciones moviles de la universidad **Uteco**

## Contenido
El contenido demostrado en el laboratorio comprende los siguientes temas:
* Estilos locales en paginas.

```xml
<ContentPage.Resources>
    <Style TargetType="Button">
        <Setter Property="FontSize">32</Setter>
    </Style>
</ContentPage.Resources>
```

* Estilos Globales en el **App.xaml**

```xml
<Application.Resources>
    <ResourceDictionary>
        <Style TargetType="Label" x:Key="BaseLabel">
            <Setter Property="FontAttributes">Italic</Setter>
            <Setter Property="HorizontalOptions">FillAndExpand</Setter>
        </Style>
    </ResourceDictionary>
</Application.Resources>
```
* Estilos explicitos.
```xml
<Label Style="{d:StaticResource Key=Body}"  Text="Email"></Label>
```
* Estilos implicitos.
```xml
<Style TargetType="Label">
    <Setter Property="FontAttributes">Italic</Setter>
    <Setter Property="HorizontalOptions">FillAndExpand</Setter>
</Style>
```
* Herencia de estilos.
```xml
<Style TargetType="Label" x:Key="Body"
        BasedOn="{d:StaticResource BaseLabel}">
    <Setter Property="TextColor">DarkGray</Setter>
    <Setter Property="FontSize">30</Setter>
</Style>
```
* Estilos estaticos y dinamicos.
```xml
<Button
    Clicked="cambiarTema"
    Text="Cambiar Tema"
    Style="{d:DynamicResource Key=buttonTheme}"
    HorizontalOptions="FillAndExpand" />
```

## Recursos
* [Estilos en Xamarin Forms](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/styles/xaml/)

* [Presentacion usada en clases](https://docs.google.com/presentation/d/13YeGP-xa_ym1A1EL6JJcKq7XehT4Y5RhTCQbQuWLMa0/edit?usp=sharing)