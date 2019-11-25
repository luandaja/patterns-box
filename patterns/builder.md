---
description: This is summary from the talk session.
---

# Builder

## ✅Goal

_**"Separate the construction of a complex object from its representation so that the same construction process can create different representations"**_

First, we have a complex object not a very simple object so the construction is a process and its representation is its data so we are going to separate logic and data and the reason of why we are doing this separation is so that the same construction process can create different representations.

So to summarize, the main objective of this pattern is to reuse this logic to work with a different set of data to build the same thing. 

Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

## 🏛Architecture

let's start talking about the participants of this pattern

The Participants

The Builder which is the core,is used by the Director,  and that builder is implemented by a Concrete Builder   so we have a concrete version of our Builder,  is actually an object that we can instantiate and then we have a Product  that the Concrete Builder is able to produce. 

So basically we create a concrete builder, we give it to the Director and  this class follows a step or has the process to Build a Product and so the builder in this examples is going to define for us what the steps are and the director is going to put those steps in the right order.

## 🌎Real case example

Image 1

So, lets start digging into this pattern with a basic example of buying a sandwich

So on and so for,  i’m sure that if you go for a sandwich it could be annoying to answer all this questions and we often just pick a number of the menu and so this is a kind 
of example of code you may have that has all extra dialog and maybe you’ve  thought well i can put all in a constructor and so you gave a large constructor where you pass in all these parameters.

Image 2

So, this dialog is much shorter, so this kind of scenario that might not really happen in a real sandwich shop, but it would be pretty efficient if it did,
so the basic idea here is that you’re only Providing data.  you are not going to the sandwich shop in this case and you are not saying 

First  cut the bread, and then put some meat etc.  you are not going to that entire Process and giving them detailed steps, instead, you’re giving them a list of ingredients 
and then they are going to follow the steps that they already know on how to make a sandwich, and every place that there’s a question they need some data,  they are going to get that from your ingredients list.

## ☢What problems does it solve?

{% hint style="success" %}
**Too many parameters.**  
This is probably a common problem that you have seen in your code and we are gonna see how this pattern solve this.
{% endhint %}

{% hint style="success" %}
**Order dependent.**  
So sometimes when we construct an object with many parameters  we have to follow an order and so we usually don’t remember what does all these parameters means and that’s gonna be an issue for us.
{% endhint %}

{% hint style="success" %}
**Different constructions.**  
We are going to find that we need to be able to construct different objects or different constructions of that object and so we need to be able to abstract out the process from the data, a lot of times in patterns we are gonna find this common idea of abstracting away data and process so we can take logic and data separate them out, and that’s gonna give us actually a Builder Pattern.
{% endhint %}

## ⏲When to use it?

{% hint style="success" %}
**When we have some kind of a complex object.**  
If is just a simple object that doesn’t have much data, it’s not going to make much sense to use this pattern
{% endhint %}

{% hint style="success" %}
**When you have too many different kind of data when building an object.**  
That means when you have to create different kinds of products or objects following the same steps but with its specific data.
{% endhint %}

## ⚠When not to use it?

{% hint style="success" %}
**When there will not be too many “Concrete Builder” implementations.**  
Because real the purpose of the pattern is to reuse the building logic with different data. if you have only one set of data you are creating an overhead, not getting a lot of value.
{% endhint %}

## ‼Common mistakes when implementing

{% hint style="danger" %}
**Forcing the pattern.**  
Force to apply the pattern when you don’t need it. For instance, when you only have one parameter in the construction of the object.
{% endhint %}

{% hint style="danger" %}
**Apply the pattern when you are not sure it will be worth it.**  
This one is very important. The developer may want to implement the pattern considering it will provide a huge benefit in a possible future requirement. However, it is not a fact that it will happen. In this case, we may end up having extra flexibility that will not be used. We can have in mind the YAGNI principle (which means “you aren’t gonna need it”). This principle states that a developer shouldn’t add any additional functionality until it is needed.
{% endhint %}

{% hint style="danger" %}
**Products don’t have an inheritance hierarchy.**  
So you could possible have this but in general in this pattern  it doesn’t say that you must, what’s really happening here is that you are getting different data. People often try to make a hierarchy of  Products and you are having one type of thing but you’re having different type of data for it and that’s really why Builder is design to do.
{% endhint %}

## 🎭Effects

### Advantages

{% hint style="success" %}
**Single Responsibility Principle.**  
We are following this principle while having each functionality logic and data  in their correspondent class.
{% endhint %}

{% hint style="success" %}
**Open/Closed Principle.**  
Once finished an implementation, you can keep creating additional abstractions without affecting the created ones.
{% endhint %}

{% hint style="success" %}
**Scalability.**  
As mentioned before, having the functionalities separated allows an easier way to scalate simply by adding the functionalities without affecting the others.
{% endhint %}

{% hint style="success" %}
**Testability.**  
Also, it is easier to test each of this classes since they are separated and focused in a specific task.
{% endhint %}

### Disadvantages 

{% hint style="danger" %}
**More complicated code by applying the pattern.**  
This aspect is very important to consider when implementing the pattern. It is easier to keep duplicating the functionality when it is very similar. But when implementing the pattern, you change that ease for an organized, well structured, scalable and testable app. But at the end, you are losing ease in exchange of a complicated code.
{% endhint %}

## Demo 

{% hint style="info" %}
The demo is hosted on the next github repository
{% endhint %}

\[Link here\]

