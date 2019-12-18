---
description: This is summary from the talk session.
---

# Strategy

## ✅Goal

_**"Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it."**_

The main idea is to identify the parts of your program that vary and separate them from what stays the same.

## 🏛Architecture

Here we have a context class, this class will ask to actually do the work.In its construction, it takes an instance, a concrete instance of a class that implements our strategy interface. this interface declares a method  that will be the one called by the context class to actually perform the calculation we're interested in performing.  Now this context will perform an action could be an user input for example, and it would then use the strategy that it was given on its constructor  to call shippingCalculation on a concrete class and in this case we have  two concrete implementations of our strategy interface

## 🌎Real case example

The idea here is that we have a customer who is checking out a website and we need to calculate the shipping order to them, now the cost may vary depending on how the customer has chosen they want the package to arrive, the customer has the choise of choosing   FEDEX , UPS and  the united states postal service  and depending on wich carrier the customer has chosen  during the checkout process.

## ☢What problems does it solve?

{% hint style="success" %}
**Exchanging methods, behaviours at run-time.**  
How can a class be configured with an algorithm at run-time
instead of implementing an algorithm directly?
How can an algorithm be selected and exchanged at run-time?
{% endhint %}

{% hint style="success" %}
**Inflexible code.**  
How can hard-wired algorithms (compile-time implementation dependencies) be refactored?
{% endhint %}

{% hint style="success" %}
**Duplicated code**  
How can many related classes that differ only in their algorithms be replaced
by a common class that is configured with one of many algorithms?
{% endhint %}

## ⏲When to use it?

{% hint style="success" %}
**When you need to use several algorithms with different variations.**  
{% endhint %}

{% hint style="success" %}
**When you have to add new behaviours to an object.**  
{% endhint %}

{% hint style="success" %}
**When most of your classes have related behaviours.**  
{% endhint %}


## ⚠When not to use it?

{% hint style="danger" %}
**When new behaviours will not be added to the class.** 
{% endhint %}


## ‼Common mistakes when implementing

{% hint style="danger" %}
**Forcing the pattern.**  
Try to apply strategy when I can solve a problem easily with an array-list-dictionary.
{% endhint %}

## 🎭Effects

### Advantages

{% hint style="success" %}
**Single Responsibility Principle.**  
We are following this principle while having each strategy in their correspondent class.
{% endhint %}

{% hint style="success" %}
**Open/Closed Principle.**  
this also very relevant, because,Strategy allows you to extend a logic in some parts of your code ("open for extension") without rewriting those parts ("closed for modification").
{% endhint %}

{% hint style="success" %}
**Scalability.**  
As mentioned before, having the functionalities separated allows an easier way to scalate simply by adding the functionalities without affecting the others.
{% endhint %}

{% hint style="success" %}
**Testability.**  
Also, it is easier to test each of this classes since they are separated and focused in a specific task.
{% endhint %}

{% hint style="success" %}
**Cyclomatic complexity.**  
We will reduce cyclomatic complexity of our application because we are separating each strategy in their correspondent class, remember whenever we use a conditional statement in our methods we are adding extra complexity to the application and adding a new behaviour that should be tested.
{% endhint %}


## Demo 

{% hint style="info" %}
The demo is hosted on the next github repository
{% endhint %}

\[Link here\]

