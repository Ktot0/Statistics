# Week 1


## Objectives:

* Research
1. Definition of statistics
2. What is a dataset? From the observation units to the dataset attributes and values
3. Find intresting application of statistics in cybersecurity

* Application
1. Create a simple application in C# and VB.net


* Research on App
1. Main differences between C# and VB.net

## Assignment
### Research
* Statistics is a science that studies and handles uncertainty by modeling, organizing, analyzing and representing data. Statistical inference permits to understand more about a statistical population.
Data are collected in datasets where they’re structured and organized in a relevant way. When studying a phenomenon or a situation in a given context, every element of the analysis is called unit. The collection of this units composes the dataset. Every observed unit can have one or more attributes: if there’s only one attribute, we’re using univariate statistics; otherwise, we’re using multivariate statistics.
Through math, statistics is concerned with analyzing and representing the data contained in datasets, in order to better understand reality and minimize risks resulting from randomness.
Being able to manage uncertainty is extremely crucial when dealing with critical situations. Nowadays, and every day more, a lot of delicate activities are handled by computers: hospitals, transports, governments, but also services, market, businesses and so on. A lot of things could go wrong, especially for what concerns cybersecurity of critical infrastractures. Since security isn’t guaranteed, perfect and constant, there are a lot of unpredictable threats that can be modeled through statistical analysis.
As example, a good security governance is made upon reasonable impact-effort choices: if a cyber-attack is very unlikely to happen, is admittable not to invest huge amount of resources on defense against it; instead, protecting against very common and likely attacks is a good strategy. Anyway, there are grey situations in wich decisions must be considered more finely, based precisely on their probability to occur.
Also defensive security is enhanced by statistics: a firewall that detects abnormal behaviour from a host could decide to treat it as malicious, depending on the probability that it really is.
To give another example, a lot of classic ciphers are vulnerable against frequency analysis, a cryptoanalysis technique to discover the hidden plaintext by observing the frequency of each letters that is visible in the ciphertext. Studying the frequency analysis means to model a set of units, the letters, and trying to find a meaning behind their representation to break the code and discover a secret message.
Alan Turing, who is considered the father of moderns computers, together with his team of Bletchley Park, has been able to decrypt Enigma‘s nazis secret messages. He contributed to the end of World War II: this has been possible also thanks to statistics.

### App
* Load data from a simple file [test.csv](https://github.com/Ktot0/Statistics/blob/main/week1/test.csv)
* Perform some basic operations (Min, Max, Avg).

[C# Release](https://github.com/Ktot0/Statistics/tree/main/week1/Exercise_1)

[VB.Net Release](https://github.com/Ktot0/Statistics/tree/main/week1/Exercise_1_vb)

### Research on App
* Main differences so far between VB and C# are:

1. VB uses the keyword Me to refer to the Form object; C#, instead, uses the keyword “this“;
2. In conditional statements, VB uses a single equal symbol (=), while C# used the most common double equal symbol (==);
3. To concatenate strings, VB net uses the & symbol; C#, instead, uses the + symbol;
4. VB doesn’t uses curly brackets, while C# uses them. Concrete examples can be found in the source code on GitHub above;
5. VB uses PascalCase as a naming convention, while C# uses camelCase.
