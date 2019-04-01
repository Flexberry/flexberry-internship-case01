    $(function() {
      $('.Form').draggable({
      })
      $('.PartOfNetwork').draggable({
        })
      $('#ThermoObject').droppable({
        over: function(event,ui){
          ui.draggable.removeClass("OuterNetwork")
          ui.draggable.addClass("InnerNetwork")
        },
        out: function(event,ui){
          ui.draggable.removeClass("InnerNetwork")
          ui.draggable.addClass("OuterNetwork")
        }
        })
    })
    $(document).ready(function(){
        $('#Overlay').hide();
        $('.Form').hide();
        $(document).on('click', '.Edit', function(event){
          $('#Overlay').show()
          $('.Form').show();
          var t = $('#'+event.target.parentNode.parentNode.id); // в t будет лежать PartOfNetwork по которому был клик
          t.addClass("Highlighted")
          if (t.hasClass("OnGround")) {$('#SelectKindOfLaying option:selected').text("Надземная")}
          if (t.hasClass("UnderGround")) {$('#SelectKindOfLaying option:selected').text("Подземная")}
          if (t.hasClass("InBasement")) {$('#SelectKindOfLaying option:selected').text("По подвалу")}
          $('#PONNumber').val(t.find('.NN').val()); //переносим номер участка сети в форму
          $('#SelectIsolation option:selected').text(t.parent().next().find('.NI').val()); //устанавливаем тип изоляции в форму из участка сети
        });
        $('#ButtonSubmit').click(function(event) {
          $('#Overlay').hide();
          var form = $('.Form');
          var editingNumber = $('#PONNumber').val();
          var editingPartOfNetwork = $('#Networks').find('#PON_'+editingNumber);
          editingPartOfNetwork.find('.NI').val($('#SelectIsolation option:selected').text()); //Переносим тип изоляции из формы в участок сети
          if ($('#SelectKindOfLaying option:selected').text() == "Надземная") {
            editingPartOfNetwork.removeClass("UnderGround")
            editingPartOfNetwork.removeClass("InBasement")
            editingPartOfNetwork.addClass("OnGround")
          }
          if ($('#SelectKindOfLaying option:selected').text() == "Подземная") {
            editingPartOfNetwork.removeClass("OnGround")
            editingPartOfNetwork.removeClass("InBasement")
            editingPartOfNetwork.addClass("UnderGround")
          }
          if ($('#SelectKindOfLaying option:selected').text() == "По подвалу") {
            editingPartOfNetwork.removeClass("OnGround")
            editingPartOfNetwork.removeClass("UnderGround")
            editingPartOfNetwork.addClass("InBasement")
          }
          form.hide();
          editingPartOfNetwork.removeClass("Highlighted");
        })
        $('#ButtonCancel').click(function() {
          $('#Overlay').hide();
          var form = $('.Form');
          form.hide();
          var editingNumber = $('#PONNumber').val();
          var editingPartOfNetwork = $('#Networks').find('#PON_'+editingNumber);
          editingPartOfNetwork.removeClass("Highlighted");
        })
        $('#AddButton').click(function(event) {
          var count = $('#Networks').children().length;
          var newdiv = '<div id="PON_' + (count+1) + '" class="PartOfNetwork OuterNetwork OnGround"><div class="ButtonPlace"><button class="Edit"></button></div><div class="ContentPlace"><div class="number"><span class="SpanNumber">Номер: </span><input type="text" class="NN" disabled/></div><div class="NetworkIsolation"><span class="SpanIsolation">Тип изоляции: </span><input type="text" class="NI" disabled/></div></div></div>';
          $('#Networks').append(newdiv);
          $('#Overlay').css("height","100%");
          $('.PartOfNetwork').draggable({
            })
          $('#Networks').children().last().find('.NN').val(count+1);
          $('#Networks').children().last().find('.NI').val('Пенополиуретан');
        })
    });
