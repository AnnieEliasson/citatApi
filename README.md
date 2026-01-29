## QuoteAPI - Random Weather Quotes

### Random quote

GET /api/quote

```
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```

### All quotes

GET /api/quote/all

```
[
    {
        "id": 1,
        "text": "Efter regn kommer… mer regn. Men också erfarenhet."
    },
    ...
]
```
### Quote by Id

GET /api/quote/1

```
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```

### Search quote

POST /api/quote/search?s=regn

```
[
  {
    "id": 1,
    "text": "Efter regn kommer… mer regn. Men också erfarenhet."
  },
  {
    "id": 7,
    "text": "Regn förstör inga planer – det avslöjar bara hur flexibla de var."
  }
]
```