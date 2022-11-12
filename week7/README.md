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


# Week 7


## Objectives:

* Research

1. Try to understand the general idea of the Lebesgue-Stieltjes integral and why it is useful concept and notation in Theory of Probability
2. Explain in your own words the "Law of large numbers" and sketch a simple proof (Markov inequality, Čebyšëv inequality, ... )

* Application

1. Consider a general scheme ad the simulation of previous homework and simulate the distribution of p = SUM(xi) , where xi are Bernoulli(lambda/n), with success probability lambda /n, where lambda is a user constant ("arrival rate").Also plot the distribution of the "interarrival times".Finally, search on the web to understand what you have actually simulated

* Research on App

## Assignment
### Research


1. Try to understand the general idea of the Lebesgue-Stieltjes integral and why it is useful concept and notation in Theory of Probability:

    The Lebesgue–Stieltjes integration is a generalization of both Riemann and Lebesgue integration, carrying the advantages of the first and the general theoretical framework of the latter. The main difference between this form of integration and the one Lebesgue proposed stands in the use of the Lebesgue–Stieltjes measure associated with any function of bounded variation on the real line.
    
    The Lebesgue-Stieltjes integral:
    
    $$\int_{a}^{b}{f(x)dg(x)}$$
    
    is defined when $f:[a,b]\rightarrow \mathbb{R}$ is a Borel-measurable and bounded and $g:[a,b]\rightarrow \mathbb{R}$ is a bounded variation in $[a,b]$ and right-continuous, or when $f$ is non-negative and $g$ is monotone and right-continuous. 
    
    In probability, the expected value is calculated as:
    
    $$\int_{a}^{b}{xdF(x)}$$
    
    where $dF(x)$ is the probability measure, $F(x)$ is the cumulative density probability equal to the antiderivative of $f$.
    
    
2. Explain in your own words the "Law of large numbers" and sketch a simple proof (Markov inequality, Čebyšëv inequality, ... ):

    According to the law of large numbers, the average of the results obtained converges to the expected values after a large number of trials, becoming even closer every time a new attempt is performed. This theorem only applies to the average while in other formulas, such as the raw deviation, the theoretical results do not converge to zero but tend to increase in absolute value. Markov's inequality gives an upper bound for the probability that a non-negative function of a random variable is greater than or equal to some positive constant, while Čebyšëv inequality guarantees that no more than a certain fraction of values can be more than a certain distance from the mean in a distribution. 
