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

## ☢What problems does it solve?

* Not being able to pass information between two separate incompatible interfaces.

## ⏲When to use it?

* When there is a class whose interfaces do not match the one we need. For example a library that would be helpful to your application does not implement the interface you require.
* When we want to future proof existing code that adapts an incompatible library. This way we are not tied forever to the same libray but if needed, we can change it by implementing another adapter.
* When we want to decouple our code from the usage of an specific external library. Since we are using an interface rather than a specific class, we can easily change from one adapter implementation to another. 


## ⚠When not to use it?

* When we want to add behavior to the incompatible interface

## ‼Common mistakes when implementing

* Confusing the pattern with other ones:
	* Adding logic on top of the adaptee behaviour (Decorator)
	* Hide complex logic that the adaptee uses (Facade)
* The goal of the adapter pattern is not to add, remove or alter the behaviour of the adaptee.

### Advantages

* Complies to the Open/Closed Principle
* Increases reusability and flexibility
* Clients become simplified

### Disadvantages 

* The rabbit trail effect
* Prone to over-engineering

## Demo 

{% hint style="info" %}
The demo is hosted on the next github repository
{% endhint %}

\[Link here\]

