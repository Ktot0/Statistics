# Week 4


## Objectives:

* Research
1. Illustrate the parallel between the properties of the relative frequencies and the axioms for probability.
2. Discuss some concept examples of Measure Space (&Omega;, &epsilon;, P).
3. Illustrate how Measure Theory provides the mathematical foundation for Probability theory.

* Application
1. Simulate a sequence of coin-tosses (0 success, 1 unsuccess) and draw a dynamic chart of the relative frequency of a success fs=ms/m, absolutte frequency ms, Normalized frequency ms/sqrt(m). 

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

$$P(&Omega;) = 1$$


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

$$&mu;(\bigcup_{k=1}^{\infty}{E_k}) = \sum_{k=1}^{\infty} &mu;(E_k)$$


### App


[Coin-Tosser](https://github.com/Ktot0/Statistics/tree/main/week4/Week4_EX1)

