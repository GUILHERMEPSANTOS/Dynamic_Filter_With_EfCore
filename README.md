## :rocket:  Filtro Dinâmico com Expression Trees e o Padrão Interpreter no EF Core 

Este projeto demonstra o uso poderoso das Expression Trees em conjunto com o padrão de design Interpreter para criar filtros dinâmicos no Entity Framework Core. Combinando essas duas abordagens, você pode criar consultas flexíveis.

### Como Funciona
 **:deciduous_tree: 1. Expression Trees:**
- As Expression Trees permitem representar consultas como árvores de objetos.
- Essas árvores capturam a lógica da consulta de forma estruturada.
- Isso possibilita a criação de filtros complexos sem escrever consultas SQL manualmente.

**:raccoon: 2. Padrão Interpreter:**
- Implementamos o padrão Interpreter para interpretar as árvores de expressão.
- O padrão permite avaliar e traduzir as árvores em consultas SQL.

**:fire: 3. Filtro Dinâmico:**

- Os usuários podem criar seus próprios filtros em tempo de execução.
- Interpretamos esses filtros usando Expression Trees e o padrão Interpreter.
- O filtro é convertido em uma expressão que o Entity Framework pode processar.

## **Exemplo de Uso:**

**Entrada:**
```json
{
    "filters": [
        {
          "property": "Name",
          "filterType": "contains",
          "value": "gu"
        },
        {
         "property": "DateOfBirth",
         "filterType": "lessThan",
         "value": "2007-08-05 00:23:20.3141665"
        },
			  {
         "property": "RegistrationDate",
         "filterType": "greaterThan",
         "value": "2018-08-05T00:23:20.3141668"
        },
				{
         "property": "active",
         "filterType": "equals",
         "value": true
        }
    ],
    "take": 10,
    "skip": 0
}


```
**Controller:**
```cs
       [HttpPost]
        public async Task<IActionResult> GetCostumerByFilter([FromBody] PaginationFilter paginationFilter)
        {
            var expressionDynamic = _dynamicFilter.Generate<Customer>(paginationFilter.Filters.ToList());
            var customers = await _context.Customers.Where(expressionDynamic).ToListAsync();

            return Ok(customers);
        }
```
**Saída:**
```json
[
	{
		"id": "de186d50-d218-4c81-9dbc-9dff0ff39946",
		"name": "Guilherme",
		"email": "guilherme@hotmail.com",
		"active": true,
		"registrationDate": "2020-08-05T00:23:20.3141582",
		"dateOfBirth": "2005-08-05T00:23:20.3141599"
	}
]
```

## **Como rodar:**

  **:whale: Obs: É considerado que você tenha o Docker instalado previamente.**

  Entre neste diretório [docker](./docker) e rode o comando:
```yml 
  docker-compose up
```


