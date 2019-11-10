/*
									************************ PADRÕES ESTRUTURAIS ******************************
*/
Padrões estruturais trabalham com o arranjo e o relacionamento entre as classes do sistema.
Eles focam em como as classes são compostas para formarem maiores e mais complexas estruturas.
Eles precisam levar em conta todas as classes que compõem o sistema.
	Existem sete padrões:
		adapter,
		bridge,
		composite,
		decorator,
		façade,
		flyweight e proxy.

Suas tarefas incluem:
	Controlar e garantir acesso a um objeto.
	Mapear chamadas de uma classe para outra com estrutura diferentes.
	Adicionar novas funcionalidades para um objeto existente.
	Utilizar um pequeno numero de objetos para um grande numero de requisições.
	Simplificar acesso para um subsistema complexo.

ADAPTER = Combina interface de classes que em outro caso seriam incompativeis.
BRIDGE = Separa a abstração de sua implementação.
COMPOSITE = Permite criar uma estrutura de arvore para trabalhar de um jeito uniforme com itens.
DECORATOR = Adiciona caracteristicas ou funcionalidades a um objeto de forma dinamica sem herança.
FAÇADE = Fornece um jeito simplificado de acessar subsistemas.
FLYWEIGHT = Fornece um grande numero de requisições para um objeto por compartilhar uma instancia existente.
PROXY = Fornece um espaço reservado para um objeto para controlar o acesso a ele.