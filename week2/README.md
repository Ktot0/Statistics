# Week 2


## Objectives:

* Research

1. Concept of distribution. Univariate and multivariate. Conditional and marginal distributions.

* Application

1. Make a simple program which uses the objects RANDOM and TIMER.
2. Make a simple CSV parser
3. Compute an univariate distribution of a variable.

* Research on App

1. CSV protocol RFC-4180 (Definition and rules)

## Assignment
### Research
* In statistics, the distribution, also known as "frequency" or "absolute frequency", is the number of times the observation of an event occurred in a study. These frequencies are often depicted graphically or in tabular form. When using a tabular form, we obtain a "frequency distribution table". Usually, it is an arrangement of the values that one or more variables take, each with the count of the occurrences of the values. We talk about univariate frequency tables when the occurrences of a single variable are taken into place. If two or more variables are counted we are dealing with a multivariate table. A marginal distribution is a distribution that takes into account only a subset of variables. It gives the probabilities of various values of variables in the subset without reference to values of other variables. In contrast, a conditional distribution gives the probabilities contingent upon the values of the other variables.


### App


[Random and Timer](https://github.com/Ktot0/Statistics/tree/main/week2/Week2_EX1)

[CSV parser and Univariate Distribution](https://github.com/Ktot0/Statistics/tree/main/week2/Week2_Ex2)

[Test CSV file](https://github.com/Ktot0/Statistics/blob/main/week2/test.csv)

### Research on App
* A CSV or Comma separated file, is a file format used as a container for datasets organized as field-separated lists. It is standardized according to RFC 4180:

1. Each record is located on a separate line, delimited by a line break (New line).
2. The last record in the file may or may not have an ending line break.
3. There may be an optional header line appearing as the first line containing a name for each field. The header must have the same format as the normal record line.
4. Within the header and each record, there may be one or more fields, separated by commas.  Each line should contain the same number of fields throughout the file.  Spaces are considered part of a field and should not be ignored.  The last field in the record must not be followed by a comma.
5. Each field may or may not be enclosed in double-quotes. If fields are not enclosed with double quotes, then double quotes may not appear inside the fields.
6. Fields containing line breaks (New Line), double quotes, and commas should be enclosed in double quotes.
7. If double quotes are used to enclose fields, then a double quote appearing inside a field must be escaped by preceding it with another double quote.

