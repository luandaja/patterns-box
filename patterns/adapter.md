---
description: This is summary from the talk session.
---

# Specification

## ✅Goal

* Convert the interface of one class into another interface clients expect.
* Allow classes to work together that couldn't otherwise due to imcompatible interfaces.
* Future-proof client implementations by having them depend on Adapter interfaces, rather than concrete classes directly.

## 🏛Architecture

![](https://raw.githubusercontent.com/luandaja/patterns-box/master/patterns/.gitbook/assets/adapter_architecture.png)

## 🌎Real case example

![](https://raw.githubusercontent.com/luandaja/patterns-box/master/patterns/.gitbook/assets/adapter_real_world_case.png)

If we live in a country that uses US plug standard (first image) and we travel to Europe with one of our devices, our laptop for example, we would soon realize that our laptop plug is incompatible with most of the outlets there since they comply with the European standard (third image). So, in order to use these outlets we need something that adapts our US plug to the European outlet, that's where the plug adapter comes in place (second image).

## ☢What problems does it solve?

* Not being able to pass information between two incompatible interfaces.

## ⏲When to use it?

* When there is a class whose interfaces do not match the one we need. For example a library that would be helpful to your application does not implement the interface you require.
* When we want to future proof existing code that adapts an incompatible library. This way we are not tied forever to the same libray but if needed, we can change it by implementing another adapter.
* When we want to decouple our code from the usage of an specific external library. Since we are using an interface rather than a specific class, we can easily change from one adapter implementation to another. 


## ⚠When not to use it?

* When we want to add behavior to the incompatible interface.

## ‼Common mistakes when implementing

* Confusing the pattern with other ones:
	* Adding logic on top of the adaptee behaviour (Decorator)
	* Hide complex logic that the adaptee uses (Facade)
* The goal of the adapter pattern is not to add, remove or alter the behaviour of the adaptee.

### Advantages

* Complies to the Open/Closed Principle, since we are allowing our code to be open to extension but closed to modification. We decide how and which library to use when we implement our interface, and at the same time we enforce that the response of said library keeps being the same since that's what our client is expecting.
* Increases reusability and flexibility. We can reuse our interface anywhere we need to, again, implementing it with any library.
* Clients become simplified. All the adaption overhead is moved to the concrete implementation class.

### Disadvantages 

* The rabbit trail effect
* Prone to over-engineering

## Demo 

{% hint style="info" %}
The demo is hosted on the next github repository \[Github Repository\]: [https://github.com/luandaja/patterns-box/tree/master/demo/Adapter/AdapterDemo](https://github.com/luandaja/patterns-box/tree/master/demo/Adapter/AdapterDemo)
{% endhint %}

