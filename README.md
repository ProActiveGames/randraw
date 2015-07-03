# randraw

Random draw console app to select random rows from a csv file using random.org as random number selector

<br>

Usage:

randraw apikey input.csv output.csv numdraws /nh

>- apikey           Your API key to use random.org
>- input.csv        input file (CSV format)
>- output.csv       output file (CSV format) of randomly selected rows
>- numdraws         number for rows to randomly select and output
>- /nh              No Header (optional), specify if csv file does not have a header


eg:

    randraw 9c8c0d38-669f-4524-b03d-fe3309612c86 consumers.csv winners.csv 100

<br>

### Dependancies
Uses Random.org's API <br>
https://api.random.org/json-rpc/1/

API implementation by https://github.com/demot <br>
https://github.com/demot/RandomOrgJson-RPC
