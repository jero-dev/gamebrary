package main

import "github.com/jero-dev/gamebrary/cmd/api"

func main() {
	server := api.NewAPIServer(":8080")
	if mainError := server.Run(); mainError != nil {
		panic(mainError)
	}
}
