
<script type="text/x-mathjax-config">
    MathJax.Hub.Config({
      tex2jax: {
        skipTags: ['script', 'noscript', 'style', 'textarea', 'pre'],
        inlineMath: [['\\(','\\)'], ['$', '$']],
        displayMath: [ ['$$','$$'], ["\\[","\\]"] ],
      }
    });
  </script>
  <script src="https://cdn.mathjax.org/mathjax/latest/MathJax.js?config=TeX-AMS-MML_HTMLorMML" type="text/javascript"></script>


# Week 4


## Objectives:

* Research
1.Illustrate the parallels, between the properties of the relative frequency and the axioms for probability
2 Discuss some concrete examples of Probability measure Space
3 Illustrate how Measure Theory provides the mathematical foundation for Probability Theory

* Application
1. Generate a m sequences of n trials distributed according a Binomial with success probability p and represent the following quantities: absolute frequency of success, relative frequency of success, "normalized" relative frequency of success.
2. In the same chart, add also a vertical histogram representing the distribution of the above 3 types of frequencies on the last trial.

* Research on App

1. Give a simple introduction to graphics in the .NET environment. How to create a bitmap and a chart on it.
1. Explain in simple terms how to get device coordinates from world coordinates

## Assignment
### Research

1. Illustrate the parallel between the properties of the relative frequencies and the axioms for probability.

The Kolmogorov axioms or probability axioms are the foundations of probability theory. 

Let **&Omega;** be the sample space, **F** the event space and **P** the probability measure then (**&Omega;**, **F**, **P**) is a measure space with **P**(**E**) being the probability of some event **E** and **P**(**&Omega;**) = **1**. 

**First Axiom**

The probability of an event is a non-negative real number:

$$P(E)\in\mathbb{R}, \quad P(E)\ge0 \quad \forall \ E\in F$$


**Second Axiom**

The probability that at least one of the elementary events in the entire sample space will occur is 1.

\\[P(&Omega;) = 1\\]


**Third Axiom**

Any countable sequence of disjoint sets $E_1, E_2,...$ satisfies

$$P(\bigcup_{i=1}^{\infty}E_i)= \sum_{i=1}^{\infty} P(E_i)$$


Axiom 1 and 2 can translate to $f(\emptyset)=0$ and $f(P)=1$. Axiom 3 is equal to the additivity property for freqencies:
$$If \ A \ and \ B \ are \ disjoint: \ f(A \ or \ B) \ = \ f(A) \ + \ f(B)$$



2. Discuss some concept examples of Measure Space (&Omega;, &epsilon;, P).

* **&Omega;** is its sample space
* **&epsilon;** its &sigma;-algebra of events
* **P** its probability measure

Example Sample Space:
• Toss of a coin (with head and tail): Ω = {H, T}.
• Two tosses of a coin: Ω = {HH, HT , TH, T T}.
• A cubic die: Ω = {ω1, ω2, ω3, ω4, ω5, ω6}.
• The positive integers: Ω = {1, 2, 3, . . . }.
• The reals: Ω = {ω | ω ∈ R}.


Example Events
• Head in the coin toss: A = {H}.
• Odd number in the roll of a die: A = {ω1, ω3, ω5}.
• An integer smaller than 5: A = {1, 2, 3, 4}, where Ω = {1, 2, 3, . . . }.
• A real number between 0 and 1: A = [0, 1], where Ω = {ω | ω ∈ R}.

3. Illustrate how Measure Theory provides the mathematical foundation for Probability theory.
* **Non-negativity**: For all E in &Sigma;, we have &mu;(E) $\ge$ 0.
* **Null empty set**: &mu;( $\varnothing$ ) = 0.
* **Countable additivity**: For all countable collections $\left[ E_k \right ] _{k=1}^\infty$ or pairwise disjoint sets in &Sigma;, 

\\[&mu;(\bigcup_{k=1}^{\infty}{E_k}) = \sum_{k=1}^{\infty} &mu;(E_k)\\]


### App


[Coin-Tosser Livechart](https://github.com/Ktot0/Statistics/tree/main/week4/Week4_EX1)

[Coin-Tosser Bitmap](https://github.com/Ktot0/Statistics/tree/main/week4/Week4_EX2)

### Research on App

To create a chart using C# we need a PictureBox that has to be placed on our form, a Bitmap variable initialized using PictureBox width and hight and a Graphics variable used to draw our Bitmap to the PictureBox. 


To represent a real object in the virtual world first step is to get its width and height. Using spatial coordinates, we subtract maxX and minX to obtain its width and maxY,minY to get its height.
The next step is to define the origin of the object namely left and top. At this point virtual height and width can be chosen, resulting in the final formulas:


FromXRealToXVirtual = left + W * (X – minX)/(maxX- minX)
FromYRrealToYVirtual = top + H * (Y – minY)/(maxY – minY) 
