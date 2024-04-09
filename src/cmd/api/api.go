package api

import (
	"log"
	"net/http"
)

type APIServer struct {
	listenAddr string
}

func NewAPIServer(listenAddr string) *APIServer {
	return &APIServer{listenAddr: listenAddr}
}

func (serv *APIServer) Run() error {
	router := http.NewServeMux()

	router.HandleFunc("GET /health", func(writer http.ResponseWriter, request *http.Request) {
		writer.WriteHeader(http.StatusOK)
		writer.Write([]byte("OK"))
	})

	server := http.Server{
		Addr:    serv.listenAddr,
		Handler: router,
	}

	log.Printf("Starting server on %s", serv.listenAddr)

	return server.ListenAndServe()
}
