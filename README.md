<h4>Who can use this sample?</h4>
If you reached here, it means that you had read lots of articles about DDD.
Now you know how to think in DDD style and you are ready to start a simple project and implement an architecture with DDD philosophy.</br>
If it is so, you are in wright place, but if you work with a big team, or you have a complex project, this sample is not for you.
It will even destroy your mind about DDD! </br>
Because working with a big team in DDD way needs you to implement Ubiquitous Language among your team and implement your own architecture and concepts.
And big complex projects face with issues that my sample make those issues more complex!</br>

<h4>What should you have done before?</h4>
I considered that you had analyzed your own Domain, you had got to conclusion what are your main aggregates, and now you want to code them. In this project I try to reduce the minimum size of using libraries as MediatR or StructureMap. I will try to handle the problems as I reached them, but not before.

<h4>Architecture</h4>
Let's have a glance at my architecture:<br/>
<img src="https://i.ibb.co/rmw8Kjv/Dependencies-Graph.png" alt="Dependencies-Graph" border="1"></br>


In presentation layer users make a request through the WebApi controller.</br>
(You can add several projects to this layer, forexample a mvc project for viewing on web, an api for mobile app and others. If you want to fully achive CQRS then you can seprate your read and write methods into diffrent projects. If you want to have better management on your controllers (like diffrent versions) it's better you take Json as a parameter and serialize that in FacedeService.) </br>
The Controller give the request to the proper method on FacadeGatewayService, this service create proper command or commands and give them to the application layer, recive the result and convert them into whatever result you have in your mind.
The application call domain and repository as needed.

This is Write Side of project
