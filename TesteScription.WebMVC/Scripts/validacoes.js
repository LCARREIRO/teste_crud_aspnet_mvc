var section = {
    init: function () {
        section.mascaras();
        section.validarTelefone();
        section.validarEmail();
    },
    mascaras: function () {
        $("#Telefone").mask("(99) 99999-9999 ")          
        $("#limpar").tooltip();
        $("#pesquisar").tooltip();
        $("#entrar").tooltip();
        $("#salvar").tooltip();
        $("#editar").tooltip();
        $("#Nome").tooltip();
        $("#Email").tooltip();
        $("#Telefone").tooltip();        
    },     
}
$(document).ready(section.init);