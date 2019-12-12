---
description: >-
  "Decoupling an abstraction from its implementation so that both can vary
  independently."
---

# Bridge Pattern

### ✅Goal

The Bridge pattern seeks to decouple an abstraction from its implementation such that both can vary independently. Effectively, the Bridge maintains a reference to both abstraction and implemention but doesn't implement either, thereby allowing the details of both to remain in their separate classes.

### 🌎Real case example

Let's consider a basic scenario of making the payment related to the bonos in a company. We could have the following scenarios:

![](.gitbook/assets/Bridge1.PNG)

There is a possibility that new requirements comes, like:

* Make a deposit for arrive at work on time
* Make a direct transference for working extra hours

At this point, we can identify two dimensions that can keep expanding individualy:

* Payment Methods
* Bonos

This is a good oportunity to apply the _**Bridge Pattern**_.

### 🏛Architecture

The participants of this patterns would be:

* The **Abstraction** defines an interface and maintains a reference to an Implementor.
* The **RefinedAbstraction** extends the interface defined by the Abstraction. 
* The **Implementor** defines the interface for implementation classes. Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.
* The **ConcreteImplementor** objects implement the Implementor interface.

Let's consider the example we saw in the previous point. Having in mind the dimensions mentioned, we could apply the pattern the following way:

* The _**Payment Method**_ would the our _**Abstraction**_ so it could expose a DoPayment\(\) method.
* The _**Deposits**_, _**Checks**_, etc would be our _**Refined Abstractions**_. They would implement the DoPayment\(\) method in order to make the payment proccess according to their type of payment.
* The _**Bonos**_ would be the _**Implementation**_ that will expose a GetRemuneration\(\) method.
* Finally, the _**Achieved Goals**_, _**Extra Hours**_, etc would be the _**Concrete Implementations**_ that will have to implement the GetRemuneration\(\) method to retrieve the amount of money to be paid.

![](.gitbook/assets/Bridge2.PNG)

### ☢What problems does it solve?

{% hint style="success" %} **Reduces the classes proliferation.**  
While separating the business logic or huge classes, this pattern allows to prevent the necessity of keep creating huge classes in order to achieve a functionality. Instead, having them separed it is only needed to add a specific class that achieve the requirement. {% endhint %}

{% hint style="success" %} **Makes the system easier to maintain.**  
Having this two dimensions separated and focused on their own specific functionality, it is easier to maintain due to when needed it will be easier to know where is the functionality you want to update, fix, remove, etc. {% endhint %}

{% hint style="success" %} **Makes the system scalable.**  
Having the functionalities separated and focused, it is easier to keep adding new features without affecting the created ones. {% endhint %}

### ⏲When to use it?

{% hint style="success" %} **When you have several variants of a similar functionality.**  
Taking the first example, the similar functionality would be the payment process for each different type of bono. When we have this kind of similar duplicities, we should start considering this pattern. {% endhint %}

{% hint style="success" %} **When you have the necessity of keep expanding each dimension.**  
That means when you identify you will keep increasing any, or both, of the dimensions. In the example, we would end up having the necessity of adding new payment methods or new bonos. {% endhint %}

{% hint style="success" %} **When you want to be able to switch implementations at runtime.**  
This is more commonly used when talk about media. In video games, for example, we are able to switch the DirectX library we want to use from the menu. {% endhint %}

### 🎭Effects

#### Advantages

{% hint style="success" %} **Single Responsibility Principle**  
With this pattern, this principle is being achieved by having each functionality separated and specialized in their correspondent class. {% endhint %}

{% hint style="success" %} **Open/Closed Principle**  
Once finished an implementation, you can keep creating additional abstractions without affecting the created ones. ****{% endhint %}

{% hint style="success" %} **Scalability**  
Having the functionalities separated allows an easier way to scalate simply by adding the functionalities without affecting the others. {% endhint %}

{% hint style="success" %} **Testability**  
It is easier to test each of this classes since they are separated and focused in a specific task. {% endhint %}

#### Disadvantages

{% hint style="info" %} **More complicated code by applying the pattern**  
By applying the pattern, a large class with lot of logic can be converted in a very simple but organized structure of multiple classes. So, there is a cost when applying the pattern.{% endhint %}

### ‼Common mistakes when implementing

{% hint style="danger" %} **Forcing the pattern**  
Just trying to make the pattern to be applicable in every situation {% endhint %}

{% hint style="danger" %} **Apply the pattern when you are not sure it will be worth it**  
Implementing the pattern considering it will provide a huge benefit in a possible future requirement. However, it is not a fact that it will happen. In this case, we may end up having extra flexibility that will not be used. We can have in mind the YAGNI principle \(which means “you aren’t gonna need it”\). This principle states that a developer shouldn’t add any additional functionality until it is needed. {% endhint %}

{% hint style="danger" %} **Wait until the proliferation of classes grows too much**  
Waiting too much until you have too many of these **similar** classes will, definitely, lead you to have to deal with a refactor process in order to implement the pattern. So it is very important to be aware of possible symptoms that let you know the pattern is a good solution. Noticing them on time will be very important in order to prevent future refactoring problems. {% endhint %}

{% hint style="danger" %} **Confuse Bridge Pattern with Adapter Pattern**  
The adapter pattern seeks to provide a solution when you need to **adapt** a result so it can work properly with other process. On the other hand, the bridge pattern defines a structure so both entities work together. {% endhint %}

### Demo

{% hint style="info" %} The demo is hosted on the next github repository {% endhint %}

[\[Bridge Pattern Repository\]](https://github.com/jordinola/BridgePattern)

