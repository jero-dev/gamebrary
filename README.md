# GameBrary

**WARNING: This is still a work in progress.**

GameBrary is a video game collection manager, designed to help you keep track of your games and the ones that you want to add to your collection.

By now, GameBrary is only a simple REST API, making able to anyone to create a client for it.

In the future, we want to create a web client and a mobile client, to make it easier to use.

## Design and architecture decisions

You can find in the repository the documentation of [how and why we took the design and architecture decisions](./docs/ladr/), so you can understand them and, if you want to come with a new option, check if we try and study implementing it.

## Getting started

If you want to try and even collaborate in this project, first you need to have installed [Docker](https://docker.com/) in your machine and know how to use [DevContainers](https://code.visualstudio.com/docs/devcontainers/containers) (I use [VSCode](https://code.visualstudio.com/) for developing with them).

## MakeFile commands

Run all make commands with clean tests

```bash
make all build
```

Build the application

```bash
make build
```

Run the application

```bash
make run
```

Live reload the application

```bash
make watch
```

Run the test suite

```bash
make test
```

Clean up binary from the last build

```bash
make clean
```
