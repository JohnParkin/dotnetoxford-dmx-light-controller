This folder will contain the webapi that receives commands from the webapp, and puts those messages on the queue. The dashboard app will also be able to talk to it.

It's possible that we decide that we don't need an API at all, and the webapp can just push straight to the queue. It depends on how the dashboard works, and whether it makes sense to have an API or not.