## QuoteAPI - Random Weather Quotes

- Random quote

get /api/quote

```
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```

- All quotes

get /api/quote/all

```
[
    {
        "id": 1,
        "text": "Efter regn kommer… mer regn. Men också erfarenhet."
    },
    ...
]
```
- Quote by Id

get /api/quote/1

```
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```

- Search quote

post /api/quote/search?s=regn

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