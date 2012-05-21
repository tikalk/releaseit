

We have two main options:
1. Write each HTML template within the index page and then use them with JavaScript for layouting
2. Write just the important HTML templates within the index page and load all the rest via API

Why option 1?
-------------
We are using the Index with Razor (Razor = server side rendering) and letting the MVC parse the page only for the first time. 
So the index page can use the Razor to load all the needed views for the application to function, 
and these views can render themselves on the index as Razor Partials (@HTML.Partial()). 

Other than that all the interaction to the server should be done via WebAPI - so only data can be returned from this point on and no HTML. 
We get clean API that can serve other application as well. 
We can use VS and MVC partial to load all the templates into the index page and get better design time experience during dev.

In the worst case we can add a layout controller to return additional templates - if our templates are heavy on the network.

Why not option 2?
------------------
We could determine that we have a layout controller for lazy loading of additional views later (views = html templates)- 
But these templates must not contain any data or be bounded to data. This will cause another issue: do we cache the templates on the client? 
Do we load many templates at once or create a bundling service as well so the whole layout will load (layout consist of many templates)? 
But isn't this just loading a different page or like the ASP.NET UpdatePanel? 
The API are now handing view logic as well and returning a HTML templates.  

I guess in the end you just have to figure out the best philosophy for you. 

