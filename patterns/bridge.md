---
Bridge Pattern is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.
---

# Bridge

## ✅Goal

"Decoupling an abstraction from its implementation so that both can vary independently."

## 🌎Real case example

\[Describe your case\]

## 🏛Architecture

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

![](.gitbook/assets/architecture.PNG)

## ☢What problems does it solve?

* \[Use a bullet list to describe the problems\]
* 
## ⏲When to use it?

\[Describe conditions to use it\]

{% hint style="info" %}
\[Use hints to clarify ambiguous cases\]
{% endhint %}

## ⚠When not to use it?

\[Describe conditions to avoid them\]

{% hint style="warning" %}
\[Use warning hints to clarify ambiguous cases\]
{% endhint %}

## ‼Common mistakes when implementing

### \[Use heading 2 to summarize the mistake\]

\[and describe it bellow\]

## 🎭Effects

### Advantages

* \[Describe as bullet list\]

### Disadvantages 

* \[Describe as bullet list\]

### Drawbacks

#### \[Use heading 3 to summarize\]

\[describe it\]

{% hint style="info" %}
Use a hint to describe the suggested solution
{% endhint %}

## Demo 

{% hint style="info" %}
The demo is hosted on the next github repository
{% endhint %}

\[Link here\]

