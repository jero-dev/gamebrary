FROM golang:1.22-alpine3.19 AS BUILD
WORKDIR /src
COPY . .
RUN go build -o /bin/gamebrary ./cmd/main.go

FROM scratch
COPY --from=BUILD /bin/gamebrary /bin/gamebrary
CMD [ "/bin/gamebrary" ]