Query Validation
=======

Validation for Queries. An IQueryHandler can be used to validate an IQuery. ValidationQueryHandlerDecorator decorates IQueryHandler with a IQueryValidator. The NullQueryValidator provides a null implementation of IQueryValidator.

## Install

```
Install-Package Bocami.Practices.Query.Validation -Source https://www.myget.org/F/bocami/
```

## Dependencies
* [Bocami.Practices.Decorator (≥ 1.0.0)](https://github.com/Bocami/decorator)
* [Bocami.Practices.Query (≥ 1.0.0)](https://github.com/Bocami/query)
* [Bocami.Practices.Validation (≥ 1.0.0)](https://github.com/Bocami/validation)

## Licence
The MIT License (MIT)

Copyright (c) 2014 Jonatan Pedersen http://www.jonatanpedersen.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
